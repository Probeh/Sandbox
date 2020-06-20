using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Pokemon
{
    public class Pokemon : BaseModel<Pokemon>
    {
        public string Thumb { get; set; }
        public string Url { get; set; }
        public Pokemon(int id, string title, string url)
        {
            this.Id = id;
            this.Url = url;
            this.Description = $"{this.GetType().Name} Entry #{id.ToString().PadLeft(3, '0')}";
            this.Title = title.Substring(0, 1).ToUpper() + title.Substring(1);
            this.Thumb = this.Image = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/" + id.ToString().PadLeft(3, '0') + ".png";
            this.Image = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/" + id.ToString().PadLeft(3, '0') + ".png";
        }
    }
}
