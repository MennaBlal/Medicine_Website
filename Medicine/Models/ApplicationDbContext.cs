using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Medicine.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Qualifications> Qualifications { get; set; }
		public DbSet<Experience> Experience { get; set; }
		public DbSet<Review> Reviews { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<TimeSlots> TimeSlots { get; set; }
		public DbSet<Booking> Bookings { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
           
            modelBuilder.Entity<Specialization > ().HasData(
                new Specialization { Id = 1, Name = "Cardiology" },
                new Specialization { Id = 2, Name = "Dermatology" },
                new Specialization { Id = 3, Name = "Endocrinology" },
                new Specialization { Id = 4, Name = "Gastroenterology" },
                new Specialization { Id = 5, Name = "Neurology" }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Bio = "Experienced general practitioner.",
                    About = "Dedicated to providing thoughtful medical care.",
                    Location = "Cairo"
                },
            new Doctor
            {
                Id = 2,
               
                Bio = "Specialist in pediatric medicine.",
                About = "Committed to child health and wellness.",
                Location = "Alexandria"
            },
            new Doctor
            {
                Id = 3,
                Bio = "Cardiologist with over 10 years of experience.",
                About = "Focused on heart health and preventive care.",
                Location = "Giza"
            },
            new Doctor
            {
                Id = 4,
                Bio = "Orthopedic surgeon specializing in sports injuries.",
                About = "Helps athletes maintain optimal physical condition.",
                Location = "Luxor"
            },
            new Doctor
            {
                Id = 5,
                Bio = "Expert in internal medicine and geriatric care.",
                About = "Provides compassionate care for the elderly.",
                Location = "Aswan"
            }
          );
            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1,
                    St_date = new DateOnly(2015, 01, 01),
                    En_date = new DateOnly(2018, 12, 31),
                    Position = "Resident",
                    Hospital = "City General Hospital"
                },
            new Experience
            {
                Id = 2,
                St_date = new DateOnly(2019, 01, 01),
                En_date = new DateOnly(2020, 12, 31),
                Position = "Staff Physician",
                Hospital = "Downtown Medical Center"
            },
            new Experience
            {
                Id = 3,
                St_date = new DateOnly(2021, 01, 01),
                En_date = new DateOnly(2023, 05, 01),
                Position = "Senior Surgeon",
                Hospital = "Regional Healthcare Clinic"
            },
            new Experience
            {
                Id = 4,
                St_date = new DateOnly(2010, 06, 01),
                En_date = new DateOnly(2014, 05, 30),
                Position = "Medical Intern",
                Hospital = "University Medical Hospital"
            },
            new Experience
            {
                Id = 5,
                St_date = new DateOnly(2023, 06, 01),
                En_date = DateOnly.FromDateTime(DateTime.Now), // Assuming ongoing position
                Position = "Chief of Surgery",
                Hospital = "Advanced Medical Institute"
            }
           );

            modelBuilder.Entity<Qualifications>().HasData(
            new Qualifications
            {
                Id = 1,
                St_date = new DateTime(2010, 09, 01),
                En_date = new DateTime(2014, 06, 30),
                Degree = "Bachelor of Medicine, Bachelor of Surgery (MBBS)",
                University = "University of Health Sciences"
            },
            new Qualifications
            {
                Id = 2,
                St_date = new DateTime(2015, 09, 01),
                En_date = new DateTime(2017, 06, 30),
                Degree = "Master of Surgery (MS)",
                University = "Capital Medical University"
            },
            new Qualifications
            {
                Id = 3,
                St_date = new DateTime(2017, 09, 01),
                En_date = new DateTime(2020, 06, 30),
                Degree = "Doctor of Medicine (MD)",
                University = "Imperial College London"
            },
            new Qualifications
            {
                Id = 4,
                St_date = new DateTime(2008, 09, 01),
                En_date = new DateTime(2012, 06, 30),
                Degree = "Bachelor of Science in Nursing (BSN)",
                University = "Johns Hopkins University"
            },
            new Qualifications
            {
                Id = 5,
                St_date = new DateTime(2018, 09, 01),
                En_date = new DateTime(2021, 06, 30),
                Degree = "Doctor of Philosophy (PhD) in Medical Sciences",
                University = "Stanford University"
            }
       );
            modelBuilder.Entity<TimeSlots>().HasData(
            new TimeSlots
            {
                Id = 1,
                Day = "Monday",
                Form = new TimeOnly(9, 0), // 9:00 AM
                To = new TimeOnly(12, 0)   // 12:00 PM
            },
            new TimeSlots
            {
                Id = 2,
                Day = "Monday",
                Form = new TimeOnly(13, 0), // 1:00 PM
                To = new TimeOnly(16, 0)    // 4:00 PM
            },
            new TimeSlots
            {
                Id = 3,
                Day = "Wednesday",
                Form = new TimeOnly(10, 0), // 10:00 AM
                To = new TimeOnly(13, 0)    // 1:00 PM
            },
            new TimeSlots
            {
                Id = 4,
                Day = "Friday",
                Form = new TimeOnly(14, 0), // 2:00 PM
                To = new TimeOnly(17, 0)    // 5:00 PM
            },
            new TimeSlots
            {
                Id = 5,
                Day = "Saturday",
                Form = new TimeOnly(8, 0), // 8:00 AM
                To = new TimeOnly(11, 0)   // 11:00 AM
            }
    );

            base.OnModelCreating(modelBuilder);
        }
    }
}
