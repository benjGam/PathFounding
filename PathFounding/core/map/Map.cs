namespace PathFounding.core.map
{
    public class Map
    {
        private int _Width; // Mesured per road
        private int _Height; // Mesured per road
        public Map()
        {

        }


        #region Getters
        public int Width
        {
            get => _Width;
            set => _Width = _Width > 0 ? _Width = value : 10;   
        }

        public int Height
        {
            get => _Height;
            set => _Height = _Height > 0 ? _Height = value : 10;
        }
		#endregion
	}
}
