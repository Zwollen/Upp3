using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Up3.Models
{
    public class ShowsModels
    {
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string RunTime { get; set; }
        public string Date { get; set; }
        public string Channel { get; set; }
        public string ShowInfo { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }

        public List<ShowsModels> GetShows()
        {
            List<ShowsModels> shows = new List<ShowsModels>();
            shows.Add(new ShowsModels { Title = "Rapport", Channel = "SVT1", Genre = "Nyheter", Type = "Samhällsinfo", ShowInfo = "Rapport är ett av Sveriges Televisions nyhetsprogram och Sveriges största. Det sänds alla dagar 18.00 och 19.30 i SVT1.", Date = "2017-10-26", StartTime = "18:00", RunTime = "10", });
            shows.Add(new ShowsModels { Title = "Rapport", Channel = "SVT1", Genre = "Nyheter", Type = "Samhällsinfo", ShowInfo = "Rapport är ett av Sveriges Televisions nyhetsprogram och Sveriges största. Det sänds alla dagar 18.00 och 19.30 i SVT1.", Date = "2017-10-26", StartTime = "19:30", RunTime = "10", });
            shows.Add(new ShowsModels { Title = "Kulturnyheterna", Channel = "SVT1", Genre = "Nyheter", Type = "Samhällsinfo", ShowInfo = "Kultur och nychetsprogram", Date = "2017-10-26", StartTime = "18:13", RunTime = "10", });
            shows.Add(new ShowsModels { Title = "Opinion Live", Channel = "SVT1", Genre = "Debatt", Type = "Samhällsinfo", ShowInfo = "Debattprogram i Sveriges Television, som sänds från Göteborg.", Date = "2017-10-26", StartTime = "22:00", RunTime = "45", });
            shows.Add(new ShowsModels { Title = "Vem vet mest?", Channel = "SVT1", Genre = "Game Show", Type = "Frågesport", ShowInfo = "Ett frågesportprogram som är indelat i tre ronder.", Date = "2017-10-26", StartTime = "17:00", RunTime = "30", });
            shows.Add(new ShowsModels { Title = "Aktuellt", Channel = "SVT2", Genre = "Nyheter", Type = "Samhällsinfo", ShowInfo = "Aktuellt är ett nyhetsprogram i Sveriges Television som visas en gång varje dag utom lördagar i SVT2.", Date = "2017-10-26", StartTime = "21:00", RunTime = "40", });
            shows.Add(new ShowsModels { Title = "SVT Nyheter", Channel = "SVT2", Genre = "Nyheter", Type = "Samhällsinfo", ShowInfo = "SVT Nyheter sänder aktuella nyheter varje dag under hela året på SVT1, SVT2 och SVT24.", Date = "2017-10-26", StartTime = "16:00", RunTime = "5", });
            shows.Add(new ShowsModels { Title = "Mr.Robot", Channel = "SVT2", Genre = "Drama", Type = "Serie", ShowInfo = "En ung, asocial expert på datasäkerhet rekryteras av en underjordisk anarkistisk hackergrupp i syfte att förstöra de amerikanska storföretagens välde.", Date = "2017-10-26", StartTime = "22:15", RunTime = "50", });
            shows.Add(new ShowsModels { Title = "Vem vet mest?", Channel = "SVT2", Genre = "Game Show", Type = "Frågesport", ShowInfo = "Ett frågesportprogram som är indelat i tre ronder.", Date = "2017-10-26", StartTime = "19:00", RunTime = "30", });
            shows.Add(new ShowsModels { Title = "Oddasat", Channel = "SVT2", Genre = "Nyheter", Type = "Samhällsinfo", ShowInfo = "Samiskspråkiga nyheter.", Date = "2017-10-26", StartTime = "17:30", RunTime = "15", });
            shows.Add(new ShowsModels { Title = "TV4Nyheterna", Channel = "TV4", Genre = "Nyheter", Type = "Samhällsinfo", ShowInfo = "Kvällsnyheterna från TV4.", Date = "2017-10-26", StartTime = "19:00", RunTime = "15", });
            shows.Add(new ShowsModels { Title = "Kvällsöppet", Channel = "Tv4", Genre = "Debatt", Type = "Samhällsinfo", ShowInfo = "Svenskt debattprogram. Här uppmärksammas aktuella frågor och händelser placeras i ett bredare sammanhang.", Date = "2017-10-26", StartTime = "17:50", RunTime = "30", });
            shows.Add(new ShowsModels { Title = "Hawaii Five-O", Channel = "Tv4", Genre = "Komedi", Type = "Serie", ShowInfo = "Steve McGarrett är en tuff och cool kriminalpolis vars högra hand heter Danny ''Danno'' Williams. TV-serien följer Five-0-teamet när de bekämpar brottslighet.", Date = "2017-10-26", StartTime = "23:00", RunTime = "45", });
            shows.Add(new ShowsModels { Title = "How I Met Your Mother", Channel = "TV4", Genre = "Komedi", Type = "Serie", ShowInfo = "Serien handlar om Ted Mosby som berättar för sin son och dotter om händelserna som ledde till hur han träffade deras mamma.", Date = "2017-10-26", StartTime = "09:00", RunTime = "20", });
            shows.Add(new ShowsModels { Title = "Lost", Channel = "TV4", Genre = "Drama", Type = "Serie", ShowInfo = "Lost är en amerikansk tv-serie som följer de överlevande från en flygolycka på en mystisk tropisk ö.", Date = "2017-10-26", StartTime = "20:00", RunTime = "40", });            
            return shows;
        }
    }
}