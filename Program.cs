using System.Net.Sockets;

namespace K18
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class Keypad
    {
        public string InputCode { get; private set; } = "";
        private Display display;

        public Keypad(Display display)
        {
            this.display = display;
        }

        public void PressButton(string button)
        {
            if (InputCode.Length < 4) 
            {
                InputCode += button;
                display.Update(InputCode); 
            }
        }

        public void ClearInput()
        {
            InputCode = "";
            display.Clear(); 
        }
    }

    public class Display
    {
        private Label displayLabel;

        public Display(Label label)
        {
            displayLabel = label;
        }

        public void Update(string content)
        {
            if (displayLabel.InvokeRequired)
            {
                displayLabel.Invoke(new Action(() => displayLabel.Text = content));
            }
            else
            {
                displayLabel.Text = content;
            }
        }

        public void Clear()
        {
            Update("");
        }
    }

    public class Lockk
    {
        public bool IsLocked { get; private set; } = true;
        private string accessCode = "1234";
        public bool IsOpen { get; private set; } = false; 

        public bool TryUnlock(string enteredCode)
        {
            if (enteredCode == accessCode)
            {
                IsLocked = false;
                IsOpen = true;
                return true;
            }
            return false;
        }

        public void LockAfterTimeout()
        {
            Task.Delay(20000).ContinueWith(t => Lock());
        }

        public void Lock()
        {
            IsLocked = true;
            IsOpen = false;
        }

        public bool ValidateNewCode(string newCode)
        {
            return newCode.Length == 4; 
        }

        public void ChangeAccessCode(string newCode)
        {
            accessCode = newCode;
        }
    }

    public class Control
    {
        private string controlCode = "0000"; 

        public string GetControlCode()
        {
            return controlCode;
        }

        public bool TryChangeCodes(string enteredControlCode, string newAccessCode, Lockk lockInstance)
        {
            if (enteredControlCode == controlCode && lockInstance.IsOpen)
            {
                if (lockInstance.ValidateNewCode(newAccessCode)) 
                {
                    lockInstance.ChangeAccessCode(newAccessCode);
                    return true;
                }
            }
            return false;
        }

        public bool TryChangeControlCode(string enteredControlCode, string newControlCode, Lockk lockInstance)
        {
            if (enteredControlCode == controlCode && lockInstance.IsOpen)
            {
                if (newControlCode.Length == 4) 
                {
                    controlCode = newControlCode;
                    return true;
                }
            }
            return false;
        }
    }

    public class SecuritySystem
    {
        private Keypad keypad;
        private Lockk lockInstance;
        private Control control;
        private Display display;
        private bool isRing;

        public SecuritySystem(Keypad keypad, Lockk lockInstance, Control control, Display display)
        {
            this.keypad = keypad;
            this.lockInstance = lockInstance;
            this.control = control;
            this.display = display;
            this.isRing = false;
        }

        public async void EnterAccessCode()
        {
            if (lockInstance.IsLocked)
            {
                if (lockInstance.TryUnlock(keypad.InputCode))
                {
                    display.Update("Двері відкрито!");
                    lockInstance.LockAfterTimeout();
                }
                else
                {
                    display.Update("Невірний код!");
                }
            }
            else
            {
                display.Update("Двері вже відчинені!");
            }
            await Task.Delay(1000);
            keypad.ClearInput();
        }

        public async void ChangeAccessCode()
        {
            if (lockInstance.IsLocked)
            {
                display.Update("Двері мають бути відчинені для зміни коду доступу.");
                await Task.Delay(1000);
                keypad.ClearInput();
                return;
            }
           
            string enteredControlCode = keypad.InputCode;
            await Task.Delay(1000);
            keypad.ClearInput();

            display.Update("Введіть новий код доступу:");
            await Task.Delay(5000);

            string newAccessCode = keypad.InputCode;

            if (control.TryChangeCodes(enteredControlCode, newAccessCode, lockInstance))
            {
                display.Update("Код доступу успішно змінено.");
            }
            else
            {
                display.Update("Помилка: Невірний контрольний код або новий код.");
            }

            await Task.Delay(3000);
            keypad.ClearInput();
        }

        public async void ChangeControlCode()
        {
            if (!lockInstance.IsLocked && isRing) 
            {
                string enteredControlCode = keypad.InputCode;
                keypad.ClearInput();

                if (enteredControlCode == control.GetControlCode())
                {
                    display.Update("Введіть новий код контролю (4 цифри):");
                    await Task.Delay(5000); 

                    string newControlCode = keypad.InputCode;
                    keypad.ClearInput();

                    if (newControlCode.Length == 4)
                    {
                        if (control.TryChangeControlCode(enteredControlCode, newControlCode, lockInstance))
                        {
                            display.Update("Код контролю змінено!");
                        }
                        else
                        {
                            display.Update("Невірний контрольний код або новий код має бути 4 цифри!");
                        }
                    }
                    else
                    {
                        display.Update("Невірний новий код! Код має бути 4 цифри.");
                    }
                }
                else
                {
                    display.Update("Невірний код контролю!");
                    keypad.ClearInput();
                    await Task.Delay(3000);
                }
            }
            else
            {
                string message = "Для зміни коду контролю двері мають бути відчинені";
                if (!isRing)
                {
                    message += " та натиснута кнопка 'Дзвінок'";
                }
                display.Update(message + "!");
            }

            await Task.Delay(3000);
            keypad.ClearInput();
        }

        public async void RingBell()
        {
            isRing = true; 
            display.Update("Дзвінок подано!");
            await Task.Delay(2000);
            keypad.ClearInput();
        }
    }
}