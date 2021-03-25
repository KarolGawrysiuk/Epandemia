using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Epandemia.Models
{
    public enum Gender{
        Female,
        Male
    }
    public class User
    {

        
        public int Id { get; set; }
        [Required]
        [StringLength(8)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int HospitalId { get; set; }     
        public string Image { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }
        public virtual Hospital Hospital { get; set; }

    }
}



/*1. Zdjęcia użytkowników wyświetlić w widoku Ditalisów hospitala
 <div style="display: flex; align-items: center">
            <li>@Html.ActionLink(item.FirstName, "Details", "Users", new { id = item.Id }, null)</li>
            <img src = "~/Images/@item.Image" alt="" height="130px" width="130px" style="margin-left: 100px" />
        </div>}


2. W Detalach Pracownika dodaćlink do szpitala(podmień nazwe na nazwe szpitala)
   @Html.ActionLink(Model.Hospital.Name, "Details", "Hospitals" , new {id = Model.HospitalId  }, null)
   
   
3. Stuningować homa


4. Dodać do inicjalizera defauflowego usera ----------ZROBIONe
 inicjalizera
 model
 Link*/