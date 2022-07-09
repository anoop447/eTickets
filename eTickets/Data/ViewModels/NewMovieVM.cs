﻿using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM 
    {
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]

        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]

        public double Price { get; set; }


        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]

        public string ImageURL { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required")]

        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [Required(ErrorMessage = "End date is required")]

        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]

        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Select actors")]
        [Required(ErrorMessage = "Movie actors is required")]

        //Relationship
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a Cinema")]
        [Required(ErrorMessage = "movie Cinema is required")]

        //Cinema
        public int CinemaId { get; set; }

        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducerId { get; set; }
       





    }
}
