using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    /// <summary>
    /// Represents a session.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Gets or sets the session ID.
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the session date.
        /// </summary>
        [Required]
        public int MovieId { get; set; }
        /// <summary>
        /// Gets or sets the session date.
        /// </summary>
        public virtual Movie? Movie { get; set; }
        /// <summary>
        /// Gets or sets the session date.
        /// </summary>
        public int? CinemaId { get; set; }
        /// <summary>
        /// Gets or sets the session date.
        /// </summary>
        public virtual Cinema? Cinema { get; set; }
    }
}
