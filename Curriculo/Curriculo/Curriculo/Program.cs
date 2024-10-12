using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Path to save the PDF
        string filePath = @"C:\Users\allan\Downloads\Alan_Rodrigues_Alves_Pereira_CV_EN.pdf";

        // Create a new document
        Document document = new Document(PageSize.A4, 50, 50, 25, 25);
        PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

        // Open the document to enable you to write to the document
        document.Open();

        // Font settings
        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
        Font sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
        Font textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
        Font italicFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12);

        // Add title
        document.Add(new Paragraph("Alan Rodrigues Alves Pereira - Full Stack Engineer", titleFont));
        document.Add(new Paragraph("\n"));

        // Add Contact Information
        document.Add(new Paragraph("Contact Information", sectionFont));
        document.Add(new Paragraph("Phone: +55 41 99164-7184 (Mobile)", textFont));
        document.Add(new Paragraph("Email: alanrodriguesdev@outlook.com", textFont));
        document.Add(new Paragraph("LinkedIn: linkedin.com/in/alan-rodrigues-alves-pereira-1455b4ab", textFont));
        document.Add(new Paragraph("\n"));

        // Add Key Competencies
        document.Add(new Paragraph("Key Competencies", sectionFont));
        document.Add(new Paragraph("- Entity Framework\n- SQL\n- Dependency Injection", textFont));
        document.Add(new Paragraph("\n"));

        // Add Languages
        document.Add(new Paragraph("Languages", sectionFont));
        document.Add(new Paragraph("- Portuguese (Native or Bilingual)\n- English (Full Professional)", textFont));
        document.Add(new Paragraph("\n"));

        // Add Certifications
        document.Add(new Paragraph("Certifications", sectionFont));
        document.Add(new Paragraph("- Software Engineering and Legacy Systems\n- IT Architecture and Project Analysis\n- C# Part 1: First Steps\n- MongoDB and the Document Model\n- AWS in Practice", textFont));
        document.Add(new Paragraph("\n"));

        // Add Professional Summary
        document.Add(new Paragraph("Professional Summary", sectionFont));
        document.Add(new Paragraph("Experienced Full Stack Engineer with 9 years of experience in building and maintaining web applications for major companies like Sebrae, Mondelez, and Uninter. Specialized in .NET (Framework, Core+), WebAPI, Dapper, and MVC, with proficiency in SQL Server, Visual Studio, and Kibana. Passionate about building successful products, optimizing processes, and solving project problems efficiently.", textFont));
        document.Add(new Paragraph("\n"));

        // Add Technical Skills
        document.Add(new Paragraph("Technical Skills", sectionFont));
        document.Add(new Paragraph("- .Net, C#, ASP.Net, .Net Core +, .Net Framework\n- SQL Server, ASP.NET MVC\n- JavaScript, JSON, REST APIs\n- Git, Visual Studio, Postman", textFont));
        document.Add(new Paragraph("\n"));

        // Add Personal Qualities
        document.Add(new Paragraph("Personal Qualities", sectionFont));
        document.Add(new Paragraph("- Fast learner\n- Organized\n- Problem-solving skills\n- Experience in customer service\n- Good at giving and receiving feedback", textFont));
        document.Add(new Paragraph("\n"));

        // Add Professional Experience
        document.Add(new Paragraph("Professional Experience", sectionFont));

        string[] experience = new string[]
        {
            "Uninter Centro Universitário Internacional – FullStack Engineer .NET\nOctober 2021 – Present, Curitiba, Paraná, Brazil\n- Maintained legacy systems developed in C# using MVC.\n- Created REST APIs to decouple code and scale processes using .NET Core and SQL Server.\n- Bug fixing and process optimization using SQL Server, stored procedures, and Windows Services in C#.\n- Utilized messaging solutions like RabbitMQ and Elasticsearch for log data queries.",
            "Ebix Latin America – Systems Analyst\nMarch 2021 – September 2021, Rio de Janeiro, Brazil\n- Provided support in managing systems and integrations for insurance solutions.",
            "Ewave do Brasil (Allocated at Uninter) – Full Stack Developer\nAugust 2017 – March 2021, Curitiba, Paraná, Brazil\n- Migrated an educational module from PHP to C#, using MVC, Dapper, and SQL Server.\n- Created Gateway API for AVA system integration, developing features like payment title search and grades integration.\n- Maintained internal corporate systems, refactoring code, and implementing new features in C#.",
            "Stefanini – Junior .NET Developer\nJuly 2015 – July 2017, Curitiba, Paraná, Brazil\n- Developed and maintained task management applications using ASP.NET MVC, Entity Framework, and SQL Server.\n- Created web applications with Angular 2, WebAPI, and Entity Framework using DDD architecture and Scrum methodology."
        };

        foreach (string job in experience)
        {
            document.Add(new Paragraph(job, textFont));
            document.Add(new Paragraph("\n"));
        }

        // Add Education
        document.Add(new Paragraph("Education", sectionFont));
        document.Add(new Paragraph("Postgraduate in Computer Engineering\nCentro Universitário Internacional UNINTER (January 2023 – August 2024)\n\nBachelor's Degree in Information Technology Management\nFAEC - Faculdade Educacional de Colombo (2013 – 2015)", textFont));

        // Close the document
        document.Close();

        // Inform user
        System.Console.WriteLine("PDF generated successfully!");
    }
}
