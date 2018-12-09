using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Extensions;
using Model.DomainEntity;

namespace Model.DbContext
{
    public class ModelContentInitializer: DropCreateDatabaseIfModelChanges<ModelContext>
    {
        protected override void Seed(ModelContext context)
        {
            var part1 = new AutoPart {Name = "Подшипник"};
            context.AutoParts.Add(part1);

            var part2 = new AutoPart { Name = "Шаровая опора" };
            context.AutoParts.Add(part2);

            var part3 = new AutoPart { Name = "Ремень ГРМ" };
            context.AutoParts.Add(part3);

            var part4 = new AutoPart { Name = "Ручейковый ремень" };
            context.AutoParts.Add(part4);

            var part5 = new AutoPart { Name = "Свечи" };
            context.AutoParts.Add(part5);

            var part6 = new AutoPart { Name = "Фильтр" };
            context.AutoParts.Add(part6);

            var part7 = new AutoPart { Name = "Амортизатор" };
            context.AutoParts.Add(part7);

            var part8 = new AutoPart { Name = "Рычаг" };
            context.AutoParts.Add(part8);

            var part9 = new AutoPart { Name = "Ролик" };
            context.AutoParts.Add(part9);

            var part10 = new AutoPart { Name = "Комплект ГРМ" };
            context.AutoParts.Add(part10);

            var part11 = new AutoPart { Name = "Фара" };
            context.AutoParts.Add(part11);

            var part12 = new AutoPart { Name = "Сцепление" };
            context.AutoParts.Add(part12);

            var part13 = new AutoPart { Name = "Поршень" };
            context.AutoParts.Add(part13);

            var part14 = new AutoPart { Name = "Вкладыши" };
            context.AutoParts.Add(part14);

            var part15 = new AutoPart { Name = "Поршневые кольца" };
            context.AutoParts.Add(part15);

            var part16 = new AutoPart { Name = "Помпа" };
            context.AutoParts.Add(part16);

            var part17 = new AutoPart { Name = "Радиатор" };
            context.AutoParts.Add(part17);

            var part18 = new AutoPart { Name = "Диск тормозной" };
            context.AutoParts.Add(part18);

            var part19 = new AutoPart { Name = "Колодки тормозные" };
            context.AutoParts.Add(part19);

            var part20 = new AutoPart { Name = "Тормозной шланг" };
            context.AutoParts.Add(part20);
           
            var brand1 = new Brand
                {
                    Name = "Lemforder",
                    Logo = ".\\Content\\Logo\\Lemforder.jpg".GetBytes(),
                    Info = "О компании LEMFÖRDER стоит говорить как о марке, под знаком которой выпускаются надежные и качественные автозапчасти. Подвеска и рулевое управление-специализация компании. Потребителям предлагается 13 000 наименований деталей для легкового и грузового транспорта, каждая из которых отвечает высоким требованиям надежности и комфорта. Сегодня данная компания может похвастаться тем, что она была выбрана в качестве официального поставщика производимой продукции для всех автомобильных концернов Европы. Чтобы осуществлять оперативное управление производством и поставками, производственные мощности LEMFORDER находятся чуть ли не в каждой стране.",
                    ImageType ="jpg" 
                };
            context.Brands.Add(brand1);

            var brand2 = new Brand
            {
                Name = "SKF",
                Logo = ".\\Content\\Logo\\SKF.jpg".GetBytes(),
                Info = "AB SKF — шведская интернациональная машиностроительная компания, крупнейший в мире производитель подшипников, систем смазки и мехатроники. Штаб-квартира компании расположена в Гётеборге.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand2);

            var brand3 = new Brand
            {
                Name = "Patron",
                Logo = ".\\Content\\Logo\\Patron.jpg".GetBytes(),
                Info = "PATRON является собственной торговой маркой компании Шате - М  Плюс,  созданной  для обеспечения покупателей высококачественными автозапчастями для ремонта и технического обслуживания автомобилей. Торговая марка PATRON зарегистрирована в 2004 году и имеет международную регистрацию.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand3);

            var brand4 = new Brand
            {
                Name = "Kolbenschmidt",
                Logo = ".\\Content\\Logo\\Kolbenschmidt.jpg".GetBytes(),
                Info = "Уже более 80 лет компания KOLBENSCHMIDT занимается разработкой и производством различных типов автомобильных двигателей и запчастей для них. Ассортимент выпускаемой продукции огромен, как и перечень крупнейших автомобильных заводов, которые используют ее на своих конвейерах. Такая востребованность обусловлена тем, что автозапчасти KOLBENSCHMIDT отличаются точностью форм и долговечностью, их использование гарантирует экономичный расход топлива, надежность и безопасность эксплуатации автомобиля.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand4);

            var brand5 = new Brand
            {
                Name = "NGK",
                Logo = ".\\Content\\Logo\\NGK.jpg".GetBytes(),
                Info = " Компания NGK  — ведущий мировой производитель свечей зажигания. Компания имеет богатый инженерно-технический опыт по разработке свечей зажигания, свечей накаливания и кислородных датчиков для двигателей многих европейских автомобилей. Более 87% всех мировых автоконцернов, выпускающих легковые автомобили, выбирают свечи зажигания NGK для конвейерной комплектации.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand5);

            var brand6 = new Brand
            {
                Name = "KNECHT",
                Logo = ".\\Content\\Logo\\KNECHT.jpg".GetBytes(),
                Info = "Немецкая компания KNECHT известна на весь мир автомобильными фильтрами. Нельзя сказать, что ее путь на вершину был долгим и тернистым, потому что место на рынке было занято практически сразу. Адольф Кнехт, инженер из Германии, в 1899 году решил организовать производство фильтров, которые поначалу были производственными. Но заметив, с какой скоростью развивается автомобилестроение, ученый быстро переквалифицировался и не прогадал. Уже в 1929 году предприятие выпускало топливные, масляные и воздушные фильтры, а сама компания стала называться KNECHT FILTERWERKE. Именно ее инженеры в 1955 году на весь мир озвучили свое предложение использовать бумагу как фильтрующий элемент в автофильтрах",
                ImageType = "jpg"
            };
            context.Brands.Add(brand6);

            var brand7 = new Brand
            {
                Name = "LuK",
                Logo = ".\\Content\\Logo\\LUK.jpg".GetBytes(),
                Info = "Продукция компании LuK настолько популярна, что сцепление под этой маркой используется в каждом втором немецком автомобиле и в каждом четвертом в мире. В каталоге компании более 1000 наименований, как говорится, на все случаи жизни.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand7);

            var brand8 = new Brand
            {
                Name = "JP Group",
                Logo = ".\\Content\\Logo\\JP Group.jpg".GetBytes(),
                Info = "JP Group – известная компания упаковщик автозапчастей. Продукция для вторичного рынка экспортируется в 70 стран мира. Годовой же оборот компании перешагнул отметку в 67 миллионов евро.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand8);

            var brand9 = new Brand
            {
                Name = "SNR",
                Logo = ".\\Content\\Logo\\SNR.jpg".GetBytes(),
                Info = "SNR является пионером в области высоких технологий с начала прошлого столетия и до нынешних времен. Из небольшой  скромной компании начала 20 века SNR превратилась в международный концерн, интересы которого представлены в более чем 120 странах мира. И везде, где бы ни были отделения, компания оказывает активную помощь в  конструировании, развитии новых технологий и промышленности.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand9);

            var brand10 = new Brand
            {
                Name = "TRW",
                Logo = ".\\Content\\Logo\\TRW.jpg".GetBytes(),
                Info = "TRW Automotive — один из ведущих мировых производителей тормозных систем и рулевого управления для легковых и грузовых автомобилей. Также TRW Automotive поставляет системы активной и пассивной безопасности для всех ведущих автомобилестоительных концернов. На сборочные конвейеры поставляются системы ABS, ESP, TC, системы рулевого управления и подвески, системы подушек безопасности и ремней безопасности и многое другое.",
                ImageType = "jpg"
            };
            context.Brands.Add(brand10);

            var country1 = new Country{Name="Австрия"};
            var country2 = new Country {Name="Франция"};
            var country3 = new Country { Name = "Германия" };
            var country4 = new Country { Name = "Китай" };
            var country5 = new Country { Name = "Швеция" };
            var country6 = new Country { Name = "Дания" };
            var country7 = new Country { Name = "Япония" };
            var country8 = new Country { Name = "Турция" };
            context.Countries.AddRange(new List<Country>{country1, country2, country3, country4, country5, country6, country7,country8});

            var description1 = new Feedback { Description = "Хорошая фирма, долго ходит, нариканий нет! Рекомендую!" };
            var description2 = new Feedback { Description = "Очень часто брак... Не рекомендую!" };
            var description3 = new Feedback { Description = "Китай одним словом!" };
            var description4 = new Feedback { Description = "Лучшие тормоза и колодки!" };
            var description5 = new Feedback { Description = "Ремень ГРМ порвался, сэкономил и попал на деньги..." };
            var description6 = new Feedback { Description = "Ни раазу не пожалел о выборе данных фильтров." };
            var description7 = new Feedback { Description = "Попадается брак." };
            var description8 = new Feedback { Description = "Не рекомендую!" };
            var description9 = new Feedback { Description = "Хорошие только колодки, диски плохие." };
            var description10 = new Feedback { Description = "Можно брать." };
            context.Feedbacks.AddRange(new List<Feedback> { description1, description2, description3, description4, description5, description6, description7, description8, description9, description10 });

            var status1 = new Status { Name = "Упаковщик" };
            var status2 = new Status { Name = "Производитель" };
            context.Statuses.AddRange(new List<Status> { status1, status2 });

            var model1 = new AutoModel { Name = "Audi" };
            var model2 = new AutoModel { Name = "VW" };
            var model3 = new AutoModel { Name = "Opel" };
            var model4 = new AutoModel { Name = "BMW" };
            var model5 = new AutoModel { Name = "Toyota" };
            var model6 = new AutoModel { Name = "Nissan" };
            var model7 = new AutoModel { Name = "Fiat" };
            var model8 = new AutoModel { Name = "Mazda" };
            var model9 = new AutoModel { Name = "Mersedes" };
            var model10 = new AutoModel { Name = "Volvo" };
            context.Models.AddRange(new List<AutoModel> { model1, model2, model3, model4, model5, model6, model7, model8, model9, model10 });

            brand1.AutoParts = new List<AutoPart> { part2, part8 };
            brand2.AutoParts = new List<AutoPart> { part1, part3, part4, part9, part10, part16 };
            brand3.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            brand4.AutoParts = new List<AutoPart> { part13, part14, part15, part16 };
            brand5.AutoParts = new List<AutoPart> { part5, part11 };
            brand6.AutoParts = new List<AutoPart> { part6 };
            brand7.AutoParts = new List<AutoPart> { part1, part7, part9, part12 };
            brand8.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            brand9.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part9, part10, part16 };
            brand10.AutoParts = new List<AutoPart> { part2, part8, part18, part19, part20 };

            status1.Brands = new List<Brand> { brand3, brand8 };
            status2.Brands = new List<Brand> { brand1, brand2, brand4, brand5, brand6, brand7, brand9, brand10 };

            brand1.Feedbacks = new List<Feedback> { description1};
            brand2.Feedbacks = new List<Feedback> { description10};
            brand3.Feedbacks = new List<Feedback> { description2, description3, description5 };
            //brand4.Feedbacks = new List<Feedback> {  };
            //brand4.Feedbacks = new List<Feedback> {  };
            //brand5.Feedbacks = new List<Feedback> {  };
            brand6.Feedbacks = new List<Feedback> { description6 };
            //brand7.Feedbacks = new List<Feedback> { };
            brand8.Feedbacks = new List<Feedback> { description8 };
            brand9.Feedbacks = new List<Feedback> { description7};
            brand10.Feedbacks = new List<Feedback> { description4, description9 };

            country1.Brands.Add(brand6);
            country2.Brands.Add(brand9);
            country3.Brands = new List<Brand> { brand1, brand4, brand7, brand10 };
            country4.Brands = new List<Brand> { brand1, brand3, brand6, brand8, brand9 };
            country5.Brands.Add(brand2);
            country6.Brands.Add(brand8);
            country7.Brands.Add(brand5);
            country8.Brands = new List<Brand> { brand3, brand8 };

            model1.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model2.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model3.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model4.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model5.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model6.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model7.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model8.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model9.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };
            model10.Brands = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6, brand7, brand8, brand9, brand10 };

            model1.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model2.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model3.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model4.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model5.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model6.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model7.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model8.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model9.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
            model10.AutoParts = new List<AutoPart> { part1, part2, part3, part4, part5, part6, part7, part8, part9, part10, part11, part12, part13, part14, part15, part16, part17, part18, part19, part20 };
           
            context.SaveChanges();
        }
    }
}
