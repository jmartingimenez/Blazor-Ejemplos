using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEjemplos.Data
{
    public class ComunicacionState
    {
        public ComunicacionState()
        {
            InputValue = string.Empty;
        }

        public string InputValue { get; private set; }

        public void SetInputValue(string newValue)
        {
            InputValue = newValue;
            NotifyStateChanged();
        }

        //La siguente propiedad y el método es para el manejo del estado
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}