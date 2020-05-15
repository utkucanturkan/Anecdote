using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InitialDataList
    {
        public static List<Anecdote> Anectodes
        {
            get
            {
                return new List<Anecdote>() {
                    new Anecdote
                    {
                        Title = "En İyi Bira",
                        Content = "Birgün Carlsberg, Miller, Tuborg ve Efes Pilsen'in başkanları barda içmeye gitmiş. Garson gelince teker teker söylemişler; - Ben bi Carlsberg alayım. - Ben bi büyük Miller istiyorum. - Ben Tuborg içeceğim. Sıra Efes Pilsen'in başkanına gelince; - Ben bir kola alayım.demiş.Garson gidince yanındakiler sormuş, \"Yahu sen niye Efes Pilsen istemedin\" diye;-Kimse bira içmiyordu, ben de size uyayım dedim. demiş."
                    },
                    new Anecdote
                    {
                        Title = "Bakış Açısı",
                        Content = "Matematik dersinde kadın öğretmen öğrencilere sorar: - Bir ağacın dalında 5 tane kuş var. Taş attım, iki tanesini vurdum. Geriye kaç kuş kalır? Öğrencinin biri parmak kaldırır ve cevaplar: - Hiç kuş kalmaz çünkü diğerleri korkudan uçup gider. Öğretmen gülümser: - Hayır. Doğru cevap üç olacaktı ama bakış açını sevdim. Öğrenci duruma çok bozulur ama pek göstermez. Ders devam ederken tekrar parmak kaldırır: - Bir soru da ben sorabilir miyim? Öğretmen izin verir. - Sokakta üç kadın dondurma yiyerek yürüyor. Biri dondurmasını yalıyor, diğeri ısırıyor, diğeri de emiyor. Kadınlardan hangisi evlidir? Öğretmen şaşırır, kızarıp bozarır ama cevap da vermek zorundadır: - Hmm...şey..yalayan? Öğrenci yanıtlar: -Hayır, parmağında alyans olan. Ama bakış açınızı sevdim."
                    },
                    new Anecdote
                    {
                        Title = "Çakal Tercüman",
                        Content = "Mafya babası haraçlarını toplaması için yeni bir tetikçi buldu. Seçtiği adam sağır ve dilsizdi. Çünkü baba, bu tetikçi yakalanırsa polise fazla bir şey anlatması mümkün olamaz diye düşünüyordu. Baba, bir gün ödemelerin geciktiğini fark etti ve tetikçiyi odasına aldırttı, bir de işaret dilini bilen tercüman buldular. Tercüman işaretle sordu: \"Para nerede?\" Sağır dilsiz işaretle yanıt verdi: \"Ne parası? Benim paradan maradan haberim yok. Neden bahsettiğinizi anlamıyorum.\"Tercüman tercüme etti: \"Neden bahsettiğinizi anlamıyormuş.\" Baba 38'liği koltuk altından çekip sağır dilsizin beynine dayadı: \"Şimdi sor bakalım, para nerede.\" Tercüman işaretle sordu: \"Para nerede?\" Sağır-dilsiz kan ter içinde, işaretle yanıt verdi: \"Şehir merkezindeki parkta, büyük heykelin olduğu kapıdan girince soldan 3. ağacın kovuğunda iki yüz bin dolar var.\" \"Ne söyledi?\" dedi baba. Tercüman yanıtladı: \"Dedi ki, hala neden bahsettiğinizi anlamıyormuş, ayrıca o tetiği çekmek de biraz g.t istermiş.\""
                    },
                    new Anecdote
                    {
                        Title = "Şefkatli Tavşan",
                        Content = "Bir tavşan ormanda koşarken , esrar saran bir zürafa görür. Ona: - Dostum zürafa , içme bunu, sağlığına zararlı , koşalım form tutalım der ve başlar bunlar koşmaya. Biraz sonra kokain çekmeye hazırlanan bir fil görürler ve tavşan: - Fil arkadaşım , kokaini bırak , gel bizimle koş beraber form tutalım. diyerek ikna eder. Biraz koştuktan sonra kendine eroin enjekte etmeye hazırlanan aslanı görürler. Tavşan: - Sevgili aslan kardeş , batırma kendine bunu , gel bizimle koş, sana da iyi gelir. der. Aslan yaklaşır tavşana ve yumruğunu indirir tavşanın suratına. Diğerleri şaşkın bir şekilde: - Niye yaptın bunu, iyiliğimizi istiyordu. derler. Aslan: - Bu salak her extacy aldığında ormanda deli gibi koşturuyor bizi. der."
                    },
                    new Anecdote
                    {
                        Title = "Dil Sü\"r\"çmesi",
                        Content = "Temel askerdedir. İlk gün komutan gelir ve: - Benim adım Ali Kırç. Unutmayın Kırç, arada \"r\" var. Soyadımı yanlış söyleyen veya dalga geçen olursa yakarım. Komutan ara sıra askerlere kendi soyadını sorar. En sonunda sıra Temel'e gelir. - Temel söyle bakalım benim adım ne? Temel düşünür ama bi türlü hatırlayamaz. O sırada arkadaşı kopya verir: - Temel unutma arada \"r\" var. - Haa hatırladım komutanım. Ali Gört!!!"
                    },
                    new Anecdote
                    {
                        Title = "Temel İngilizce Konuşursa...",
                        Content = "Temel Amerika'ya gelir uçaktan iner pasaport olayı filan falan Göçmenlik Bürosu'na alırlar bunu memur sorar : - What's your name sir? - Temel. - Surname? - Kaya. - Sex? Temel gayet sakin cevaplar: - 3 times a week. Memur şaşırır ve olayı toparlamaya çalışır... - Sir you understood me wrong... I mean male? or female? Temel yine hiç beklemeden cevaplar: - Doesn't matter."
                    },
                    new Anecdote
                    {
                        Title = "Para ve Yahudiler",
                        Content = "İki Yahudi arkadaş bir katolik kilisesinin önünden geçiyormuş. Kilisenin duvarında, katolik olmayanlara hitap eden büyük bir afiş asılıymış: \" Bize gelip katolikliği kabul ederseniz hemen 30 bin dolar nakit para alacaksınız! \" Yürümeye devam eden iki arkadaş bu teklifin ciddi olup olmadığını tartışmaya başlamış. Bir hafta sonra, aynı kilisenin önünde yeniden buluşmuşlar ve biri diğerine sırrını açmış: \" O teklifin ciddi olup olmadığını hala merak ediyorum. \" Bunun üzerine arkadaşından küçümser bir tavırla şu cevabı almış: \" Ah siz yahudiler, aklınız fikriniz para! \""
                    },
                    new Anecdote
                    {
                        Title = "Züppe Satıcıya Kapak",
                        Content ="Gariban bir köylü şehre inmişti. Büyük bir mağazada iki kişinin karşılıklı oturup konuştuklarını gördü. İçerde bir masa ve üç dört koltuktan başka bir şey görünmüyordu. Merak etti ve içeri girdi: - Selamünaleyküm ağalar. - Aleykümselam hemşerim ne istiyorsun? - Merak ettim acaba burada ne satıyorsunuz? Köylü ile dalga geçmek isteyen satıcı sırıtarak cevap verdi: - Eşek satıyoruz. Köylü de taşı gediğine yerleştirdi: - Sadece ikiniz misiniz yoksa daha var mı ?"
                    },
                    new Anecdote
                    {
                        Title = "Düz Mantık",
                        Content = "Temel bir yarışmaya katılır ve kazanır. Kendisine bir kitap hediye edilir. Kitabın adı da \"Düz Mantık\" tır. Temel hediyeyi alırken sorar; -Bu kitapta ne yazıyor? -Okuyunca öğrenirsin... -Ben onunla uğraşamam, anlat bakiim sen bana. -Pekala. Bak şimdi; senin evinde akvaryum var mi mesela? -Evet var... - O zaman içinde su da vardır ?  -Evet var... - İçinde su varsa balık da vardır ? -Evet var... - Balık varsa hayvanları da seviyorsundur sen ? -Evet... - Hayvanları seviyosan insanları da seversin herhalde? -Evet... - O zaman senin sevgilin de vardır ? -Evet var. - Yaşlı görünüyorsun o zaman sen evlisindir ? -Evet. - E karın olduğuna göre de, homoseksüel değilsindir? -Evet. - Bak gördün mü? Düz mantık buna denir işte... Temel çok etkilenir.Kitabı alır koltuğunun altına eve doğru giderken Dursun'u görür... Dursun sorar; -Temel o ne? -Düz mantık kitabı! -Nası bişey bu anlat bakiim... -Bak şimdi; sizin evde akvaryum var mı ? -Yook! -O zaman sen i* nesin..."
                    },
                    new Anecdote
                    {
                        Title = "Spor İçin...",
                        Content = "Adam aşırı kiloluymuş. Sağlığı tehlikeye düşünce doktoru en kısa zamanda otuz kilo zayıflamasını söylemiş. Nasıl yapayım diye kara kara düşünürken gazetede 'garantili zayıflatma' diye bir ilan görmüş ve hemen başvurmuş. \"3 günde 5 kilo\" programına yazılmış. Ertesi günü sabah kapısı çalmış. Açınca bir de ne görsün! Karşısında 20 yaşlarında, dünya güzeli, sportmen ve üzerinde giysi olarak bir çift Nike ayakkabı bulunan bir kadın!!! Kadın kendini tanıtmış, zayıflama şirketinden geldiğini söylemiş, sırtını dönüp koşmaya başlamış, sırtında bir etiket varmış, \"yakalarsan seninim\". Adam kızın arkasından koşmaya başlamış, kilometrelerce koşmuş, kan ter içinde kalmış ama kızı ormanda yakalamış ve beraber olmuş. Programın dördüncü günü adam gerçekten de 5 kilo zayıfladığını görmüş. Şirketin zayıflatma metodunu çok beğendiğinden ikinci bir programa kaydolmuş. \"5 günde 10 kilo\". Ertesi günü yine kapısı çalınmış, karşısında daha da güzel genç bir kadın, üstelik üzerinde bir çift reebok ayakkabıdan başka bir şey yok ve sırtında yine bir etiket, \"yakalarsan seninim\". Adam yine canını dişine takıp kadının arkasından koşmuş ve kilometreler sonra yakalamış. Programı tamamlamış ve altıncı gün hakikaten 10 kilo daha verdiğini sevinçle görmüş. Bu defa, şirketin \"10 günde 20 kilo\" programına kaydolmak istemiş ama şirket yetkilisi uyarmış, \"emin misiniz, bu program gerçekten çok zor bir etaptır\". Adam ısrar etmiş, bütün zorluklara katlanacağını söylemiş. Ertesi gün kapısı çalmış, heyecanla koşup açınca karşısında iri yarı sportmen genç bir adam görmüş. Üstelik adamın üzerinde sadece koşu ayakkabıları varmış, önünde de bir etiket; \"yakalarsam benimsin\".",
                    }
                    };
            }
        }
    }
}
