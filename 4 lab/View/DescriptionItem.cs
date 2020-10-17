namespace View
{
    /// <summary>
    /// Описание элемента данных описания издания
    /// </summary>
    public class DescriptionItem
    {
        /// <summary>
        /// Описание
        /// </summary>
        private string _description;

        /// <summary>
        /// Конструктор описания
        /// </summary>
        /// <param name="argument">строковый аргумент</param>
        public DescriptionItem(string argument)
        {
            _description = argument;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description
        {
            get 
            {
                return _description;
            }
            set 
            {
                _description = value;
            }
        }
    }
}
