using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEjemplos.Data
{
    public class AppState
    {
        public int? UserId { get; private set; }
        public bool IsLoggedIn { get; private set; }

        public void SetIsLoggedIn(int userId)
        {
            IsLoggedIn = true;
            UserId = userId;
            NotifyStateChanged();
        }

        public void ClearState()
        {
            IsLoggedIn = false;
            UserId = null;
            NotifyStateChanged();
        }

        //La siguente propiedad y el método es para el manejo del estado
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}