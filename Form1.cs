using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;

namespace GetAegisubFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            DoubleBuffered = true;
        }

        //см. Восстановить умолчания, Документы необходимые для работы программы, Документы на следующую серию. И метод Создать .ass
        //4) Проверить текст "ReadMe" и всё. решение можно публиковать
                
        

        

        private List<string> CreateFoldersList()
        {

            var path = textBox2.Text;
            return new List<string>()
            {
                $"{path}{"\\a"}",
                $"{path}{"\\a2"}",
                $"{path}{"\\a3"}",
                $"{path}{"\\a4"}",
                $"{path}{"\\b"}",
                $"{path}{"\\b2"}",
                $"{path}{"\\b3"}",
                $"{path}{"\\b4"}",
                $"{path}{"\\c"}",
                $"{path}{"\\c2"}",
                $"{path}{"\\c3"}",
                $"{path}{"\\c4"}",
                $"{path}{"\\d"}",
                $"{path}{"\\d2"}",
                $"{path}{"\\d3"}",
                $"{path}{"\\d4"}",
                $"{path}{"\\f"}",
                $"{path}{"\\f2"}",
                $"{path}{"\\f3"}",
                $"{path}{"\\f4"}"

            };
        }

        



        private void КакПользоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> ReadMeLinesList()
            {

                return new List<string>()
                {
                    $"{"Copyright © 2019 Sam_Mc_Every"}" + Environment.NewLine,

                    $"{"1.Оставьте только те фотки, которые будут использованы для поиска хардсаба и построения тайминга"}" + Environment.NewLine,

                    $"{"2.Запустите программу. Выберите, откуда программа будет брать фотографии, и куда их перемещать."}" + Environment.NewLine,
                    
                    $"{"3.Выберите, путь, куда будут сохранены следующие файлы:" + Environment.NewLine + "Timing.txt, TimingAndPaths.txt, sub.txt, sub.srt, sub.ass." + Environment.NewLine + "Выбранная папка должна быть пустой."}" + Environment.NewLine,

                    $"{"Перейдите на вкладку (Папки и настройски по умолчанию)."}" + Environment.NewLine,                   

                    $"{"5.Создайте папки, в каждую из которых будет копироваться 50 фоток (пункт меню, Создать папки)"}" + Environment.NewLine,

                    $"{"6.Перейдите на вкладку (Тайминг и субтитры)"}" + Environment.NewLine,                    

                    $"{"Получите тайминг из папки с вашими фото (пункт меню, Получить тайминг)"}" + Environment.NewLine,

                    $"{"7.Перейдите на вкладку (Работа с фото и документами)"}" + Environment.NewLine,

                    $"{"Выберите фотки для копирования. Для этого щёлкните левой кнопкой мыши по одному из кружков."}" + Environment.NewLine,

                    $"{"Выберите пункт меню, Скопировать фотки)"}" + Environment.NewLine,

                    $"{"8.Если вы хотите перейти в первую же папку, куда скопировались ваши фотки, выберите пункт меню (Перейти в первую папку с копиями фоток)"}" + Environment.NewLine,
                    
                    $"{"9.Итак фотографии скопированы в папки. Из этих папок загрузите их на https://smallpdf.com/ru/jpg-to-pdf (пункт меню, Получить PDF)"}" + Environment.NewLine,

                    $"{"Происходит автоматический переход по ссылке:" + Environment.NewLine + "https://smallpdf.com/ru/jpg-to-pdf"}" + Environment.NewLine,
                    
                    $"{"10.Скачайте результаты на компьютер," + Environment.NewLine + "а с компьютера на Диск Гугл (Google Drive)"}" + Environment.NewLine,
                                        
                    $"{"11.Поочерёдно откройте их все посредством Гугл Документов (Google Docs)"}" + Environment.NewLine,

                    $"{"Результаты в формате .docx скачайте в папку, куда сохранили файлы необходимые для работы программы"}" + Environment.NewLine,
                   
                    $"{"12.Для того, чтобы воспользоваться папками снова, очистите их" + Environment.NewLine + "Перейдите на вкладку (Папки и настройки по умолчанию), выберите пункт (Очистить папки)."}" + Environment.NewLine,

                    $"{"Перейдите на вкладку (Работа с фото и документами), и снова копируйте фотографии, загружайте их на smallpdf.com, скачивайте," + Environment.NewLine + "загружайте на Гугл Диск, открывайте в Гугл Документах, и скачивайте результат в папку с документами."}" + Environment.NewLine,
                                        
                    $"{"13.Подведём итоги, текст из фотографий получен, и вы скачали его в папку с документами." + Environment.NewLine + "Остаётся объединить ваши тексты, пересохранить в sub.txt, UTF-8 и создать файл Aegisub."}" + Environment.NewLine,

                    $"{"14.Для того, чтобы объединить текстовые файлы, сначала их нужно переименовать."}" + Environment.NewLine,

                    $"{"Делается это очень просто. (Выберите пункт меню, Получить renameSn.bat (.docx))"}" + Environment.NewLine,

                    $"{"15.Переименуйте renameSn.txt в renameSn.bat и запустите его."}" + Environment.NewLine,

                    $"{"Файлы в формате .docx cменят свой названия на 01_newname.docx, где 1- это индекс файла."}" + Environment.NewLine,

                    $"{"16.Объедините текстовые файлы (пункт меню, Единый текстовый файл)"}" + Environment.NewLine,

                    $"{"17.Откройте последний MergedFile и не меняя папки назначения пересохраните его как sub.txt (Кодировка другая-UTF8)."}" + Environment.NewLine,

                    $"{"18.Перейдите на вкладку (Тайминг и субтитры). Выберите пункт меню (Получить файл Aegisub)"}" + Environment.NewLine,

                    $"{"19.Полученный файл откройте в блокноте, и удалите из него последнюю строку."}" + Environment.NewLine,

                    $"{"20.Смело откройте его с помощью программы Aegisub."}" + Environment.NewLine,

                    $"{"21.Для создания файла Aegisub на следующую серию выберите пункт меню (Документы на следующую серию)."}" + Environment.NewLine,

                    $"{"При этом рабочие документы, используемые программой будут удалены и созданы заново."}" + Environment.NewLine,
                    
                    $"{"22.По окончании работы с программой перейдите на вкладку Папки и настройки по умолчанию."}" + Environment.NewLine,

                    $"{"Выберите пункт меню, Восстановить умолчания."}" + Environment.NewLine,

                    $"{"При этом лишние папки и документы в формате 0*_newname.docx, MergedFile*.docx, Timing.txt, TimingAndPaths.txt, sub.srt, sub.txt будут удалены."}" + Environment.NewLine                    

                };
            }

            string file = "\\ReadMe.txt";
            string Read = String.Concat(textBox3.Text, file);
            
                
            
                var list1 = ReadMeLinesList();
                foreach (var dir1 in list1)
                {
                    File.AppendAllText(Read, dir1 + Environment.NewLine);
                }
            
                      

                   
                               
            
        }

        private void КопирайтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            
            
            
            
        }

        private void РазработчикамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В папке с документами будет создан TimingAndPaths.txt (Список путей к файлам)");
            //Вычисляем количество файлов
            DirectoryInfo dir2 = new DirectoryInfo(textBox1.Text);
            int quantOfFiles = dir2.GetFiles().Length;
            quantOfFiles -= 1;

            //Считываем все пути к фоткам
            string[] pathToPictures = Directory.GetFiles(textBox1.Text);
            int book = 0;

            string file = "\\TimingAndPaths.txt";
            string Read = String.Concat(textBox3.Text, file);

            
            
            
                File.AppendAllText(Read, pathToPictures[book] + Environment.NewLine);

                do
                {
                    book += 1;
                    File.AppendAllText(Read, pathToPictures[book] + Environment.NewLine);
                } while (book != quantOfFiles);
            
                    
                
          
            

        }

        private void ПолучитьТаймингToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir4 = new DirectoryInfo(textBox1.Text);
            foreach (var item in dir4.GetFiles())
            {

                string file = "\\Timing.txt";
                string Read = String.Concat(textBox3.Text, file);

                
                    
                        File.AppendAllText(Read, item.Name + Environment.NewLine);
                                          

                                   
                
            }
        }

        private void ПолучитьToolStripMenuItem_Click(object sender, EventArgs e)
        {


            
            string gorn = String.Concat(textBox3.Text, "\\sub.ass");
            string timecodes = String.Concat(textBox3.Text, "\\Timing.txt");
            string subs = String.Concat(textBox3.Text, "\\sub.txt");

            



            List<string> AegisubList()
            {

                return new List<string>()
                    {
                         $"{"[Script Info]"}",
                         $"{"; Script generated by Aegisub 3.2.2"}",
                         $"{"; http://www.aegisub.org/"}",
                         $"{"Title: Default Aegisub file"}",
                         $"{"ScriptType: v4.00+"}",
                         $"{"WrapStyle: 0"}",
                         $"{"ScaledBorderAndShadow: yes"}",
                         $"{"YCbCr Matrix: None"}" + Environment.NewLine,
                         $"{"[Aegisub Project Garbage]"}" + Environment.NewLine,
                         $"{"[V4 + Styles]"}",
                         $"{"Format: Name, Fontname, Fontsize, PrimaryColour, SecondaryColour, OutlineColour, BackColour, Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding"}",
                         $"{"Style: Default,Arial,20,&H00FFFFFF,&H000000FF,&H00000000,&H00000000,0,0,0,0,100,100,0,0,1,2,2,2,10,10,10,1"}",
                         $"{"[Events]"}",
                         $"{"Format: Layer, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text"}",


                    };
            }

            var list5 = AegisubList();
            foreach (var dir5 in list5)
            {
                File.AppendAllText(gorn, dir5 + Environment.NewLine);
            }


            //объявил файл D:\Time.txt  в массив. 
            string[] timingFile = File.ReadAllLines(timecodes);
            


            int op = timingFile.Length;
            int opa = op - 1;
            //string opi = opa.ToString();
            //int opi = 10;
            

            string[] subfile = File.ReadAllLines(subs);

            int bot = 0;
            string b = timingFile[bot];

            //string b = String.Concat(timingFile[bot], subfile[bot]);

            b = b.Replace("0.jpeg", "");
            b = b.Replace("1.jpeg", "");
            b = b.Replace("2.jpeg", "");
            b = b.Replace("3.jpeg", "");
            b = b.Replace("4.jpeg", "");
            b = b.Replace("5.jpeg", "");
            b = b.Replace("6.jpeg", "");
            b = b.Replace("7.jpeg", "");
            b = b.Replace("8.jpeg", "");
            b = b.Replace("9.jpeg", "");

            b = b.Replace("0__0", ",0");
            b = b.Replace("1__0", ",0");
            b = b.Replace("2__0", ",0");
            b = b.Replace("3__0", ",0");
            b = b.Replace("4__0", ",0");
            b = b.Replace("5__0", ",0");
            b = b.Replace("6__0", ",0");
            b = b.Replace("7__0", ",0");
            b = b.Replace("8__0", ",0");
            b = b.Replace("9__0", ",0");

            b = b.Replace("0__1", ",0");
            b = b.Replace("0__2", ",0");
            b = b.Replace("0__3", ",0");
            b = b.Replace("0__4", ",0");
            b = b.Replace("0__5", ",0");
            b = b.Replace("0__6", ",0");
            b = b.Replace("0__7", ",0");
            b = b.Replace("0__8", ",0");
            b = b.Replace("0__9", ",0");

            b = b.Replace("1__1", ",0");
            b = b.Replace("2__2", ",0");
            b = b.Replace("3__3", ",0");
            b = b.Replace("4__4", ",0");
            b = b.Replace("5__5", ",0");
            b = b.Replace("6__6", ",0");
            b = b.Replace("7__7", ",0");
            b = b.Replace("8__8", ",0");
            b = b.Replace("9__9", ",0");


            b = b.Replace("1__2", ",0");
            b = b.Replace("1__3", ",0");
            b = b.Replace("1__4", ",0");
            b = b.Replace("1__5", ",0");
            b = b.Replace("1__6", ",0");
            b = b.Replace("1__7", ",0");
            b = b.Replace("1__8", ",0");
            b = b.Replace("1__9", ",0");

            b = b.Replace("2__1", ",0");
            b = b.Replace("3__1", ",0");
            b = b.Replace("4__1", ",0");
            b = b.Replace("5__1", ",0");
            b = b.Replace("6__1", ",0");
            b = b.Replace("7__1", ",0");
            b = b.Replace("8__1", ",0");
            b = b.Replace("9__1", ",0");


            b = b.Replace("2__3", ",0");
            b = b.Replace("2__4", ",0");
            b = b.Replace("2__5", ",0");
            b = b.Replace("2__6", ",0");
            b = b.Replace("2__7", ",0");
            b = b.Replace("2__8", ",0");
            b = b.Replace("2__9", ",0");

            b = b.Replace("3__2", ",0");
            b = b.Replace("4__2", ",0");
            b = b.Replace("5__2", ",0");
            b = b.Replace("6__2", ",0");
            b = b.Replace("7__2", ",0");
            b = b.Replace("8__2", ",0");
            b = b.Replace("9__2", ",0");


            b = b.Replace("3__4", ",0");
            b = b.Replace("3__5", ",0");
            b = b.Replace("3__6", ",0");
            b = b.Replace("3__7", ",0");
            b = b.Replace("3__8", ",0");
            b = b.Replace("3__9", ",0");

            b = b.Replace("4__3", ",0");
            b = b.Replace("5__3", ",0");
            b = b.Replace("6__3", ",0");
            b = b.Replace("7__3", ",0");
            b = b.Replace("8__3", ",0");
            b = b.Replace("9__3", ",0");


            b = b.Replace("4__5", ",0");
            b = b.Replace("4__6", ",0");
            b = b.Replace("4__7", ",0");
            b = b.Replace("4__8", ",0");
            b = b.Replace("4__9", ",0");

            b = b.Replace("5__4", ",0");
            b = b.Replace("6__4", ",0");
            b = b.Replace("7__4", ",0");
            b = b.Replace("8__4", ",0");
            b = b.Replace("9__4", ",0");


            b = b.Replace("5__6", ",0");
            b = b.Replace("5__7", ",0");
            b = b.Replace("5__8", ",0");
            b = b.Replace("5__9", ",0");

            b = b.Replace("6__5", ",0");
            b = b.Replace("7__5", ",0");
            b = b.Replace("8__5", ",0");
            b = b.Replace("9__5", ",0");


            b = b.Replace("6__7", ",0");
            b = b.Replace("6__8", ",0");
            b = b.Replace("6__9", ",0");

            b = b.Replace("7__6", ",0");
            b = b.Replace("8__6", ",0");
            b = b.Replace("9__6", ",0");


            b = b.Replace("7__8", ",0");
            b = b.Replace("7__9", ",0");

            b = b.Replace("8__7", ",0");
            b = b.Replace("9__7", ",0");


            b = b.Replace("8__9", ",0");

            b = b.Replace("9__8", ",0");

            b = b.Replace("_00,", ".00,");
            b = b.Replace("_01,", ".01,");
            b = b.Replace("_02,", ".02,");
            b = b.Replace("_03,", ".03,");
            b = b.Replace("_04,", ".04,");
            b = b.Replace("_05,", ".05,");
            b = b.Replace("_06,", ".06,");
            b = b.Replace("_07,", ".07,");
            b = b.Replace("_08,", ".08,");
            b = b.Replace("_09,", ".09,");
            b = b.Replace("_10,", ".10,");

            b = b.Replace("_11,", ".11,");
            b = b.Replace("_12,", ".12,");
            b = b.Replace("_13,", ".13,");
            b = b.Replace("_14,", ".14,");
            b = b.Replace("_15,", ".15,");
            b = b.Replace("_16,", ".16,");
            b = b.Replace("_17,", ".17,");
            b = b.Replace("_18,", ".18,");
            b = b.Replace("_19,", ".19,");

            b = b.Replace("_20,", ".20,");
            b = b.Replace("_21,", ".21,");
            b = b.Replace("_22,", ".22,");
            b = b.Replace("_23,", ".23,");
            b = b.Replace("_24,", ".24,");
            b = b.Replace("_25,", ".25,");
            b = b.Replace("_26,", ".26,");
            b = b.Replace("_27,", ".27,");
            b = b.Replace("_28,", ".28,");
            b = b.Replace("_29,", ".29,");
            b = b.Replace("_30,", ".30,");

            b = b.Replace("_31,", ".31,");
            b = b.Replace("_32,", ".32,");
            b = b.Replace("_33,", ".33,");
            b = b.Replace("_34,", ".34,");
            b = b.Replace("_35,", ".35,");
            b = b.Replace("_36,", ".36,");
            b = b.Replace("_37,", ".37,");
            b = b.Replace("_38,", ".38,");
            b = b.Replace("_39,", ".39,");
            b = b.Replace("_40,", ".40,");

            b = b.Replace("_41,", ".41,");
            b = b.Replace("_42,", ".42,");
            b = b.Replace("_43,", ".43,");
            b = b.Replace("_44,", ".44,");
            b = b.Replace("_45,", ".45,");
            b = b.Replace("_46,", ".46,");
            b = b.Replace("_47,", ".47,");
            b = b.Replace("_48,", ".48,");
            b = b.Replace("_49,", ".49,");
            b = b.Replace("_50,", ".50,");

            b = b.Replace("_51,", ".51,");
            b = b.Replace("_52,", ".52,");
            b = b.Replace("_53,", ".53,");
            b = b.Replace("_54,", ".54,");
            b = b.Replace("_55,", ".55,");
            b = b.Replace("_56,", ".56,");
            b = b.Replace("_57,", ".57,");
            b = b.Replace("_58,", ".58,");
            b = b.Replace("_59,", ".59,");
            b = b.Replace("_60,", ".60,");

            b = b.Replace("_61,", ".61,");
            b = b.Replace("_62,", ".62,");
            b = b.Replace("_63,", ".63,");
            b = b.Replace("_64,", ".64,");
            b = b.Replace("_65,", ".65,");
            b = b.Replace("_66,", ".66,");
            b = b.Replace("_67,", ".67,");
            b = b.Replace("_68,", ".68,");
            b = b.Replace("_69,", ".69,");
            b = b.Replace("_70,", ".70,");

            b = b.Replace("_71,", ".71,");
            b = b.Replace("_72,", ".72,");
            b = b.Replace("_73,", ".73,");
            b = b.Replace("_74,", ".74,");
            b = b.Replace("_75,", ".75,");
            b = b.Replace("_76,", ".76,");
            b = b.Replace("_77,", ".77,");
            b = b.Replace("_78,", ".78,");
            b = b.Replace("_79,", ".79,");
            b = b.Replace("_80,", ".80,");

            b = b.Replace("_81,", ".81,");
            b = b.Replace("_82,", ".82,");
            b = b.Replace("_83,", ".83,");
            b = b.Replace("_84,", ".84,");
            b = b.Replace("_85,", ".85,");
            b = b.Replace("_86,", ".86,");
            b = b.Replace("_87,", ".87,");
            b = b.Replace("_88,", ".88,");
            b = b.Replace("_89,", ".89,");
            b = b.Replace("_90,", ".90,");

            b = b.Replace("_91,", ".91,");
            b = b.Replace("_92,", ".92,");
            b = b.Replace("_93,", ".93,");
            b = b.Replace("_94,", ".94,");
            b = b.Replace("_95,", ".95,");
            b = b.Replace("_96,", ".96,");
            b = b.Replace("_97,", ".97,");
            b = b.Replace("_98,", ".98,");
            b = b.Replace("_99,", ".99,");

            b = b.Replace("_", ":");

            b = b.Replace(":01m", ".01m");
            b = b.Replace(":02m", ".02m");
            b = b.Replace(":03m", ".03m");
            b = b.Replace(":04m", ".04m");
            b = b.Replace(":05m", ".05m");
            b = b.Replace(":06m", ".06m");
            b = b.Replace(":07m", ".07m");
            b = b.Replace(":08m", ".08m");
            b = b.Replace(":09m", ".09m");
            b = b.Replace(":10m", ".10m");

            b = b.Replace(":11m", ".11m");
            b = b.Replace(":12m", ".12m");
            b = b.Replace(":13m", ".13m");
            b = b.Replace(":14m", ".14m");
            b = b.Replace(":15m", ".15m");
            b = b.Replace(":16m", ".16m");
            b = b.Replace(":17m", ".17m");
            b = b.Replace(":18m", ".18m");
            b = b.Replace(":19m", ".19m");
            b = b.Replace(":20m", ".20m");

            b = b.Replace(":21m", ".21m");
            b = b.Replace(":22m", ".22m");
            b = b.Replace(":23m", ".23m");
            b = b.Replace(":24m", ".24m");
            b = b.Replace(":25m", ".25m");
            b = b.Replace(":26m", ".26m");
            b = b.Replace(":27m", ".27m");
            b = b.Replace(":28m", ".28m");
            b = b.Replace(":29m", ".29m");
            b = b.Replace(":30m", ".30m");

            b = b.Replace(":31m", ".31m");
            b = b.Replace(":32m", ".32m");
            b = b.Replace(":33m", ".33m");
            b = b.Replace(":34m", ".34m");
            b = b.Replace(":35m", ".35m");
            b = b.Replace(":36m", ".36m");
            b = b.Replace(":37m", ".37m");
            b = b.Replace(":38m", ".38m");
            b = b.Replace(":39m", ".39m");
            b = b.Replace(":40m", ".40m");

            b = b.Replace(":41m", ".41m");
            b = b.Replace(":42m", ".42m");
            b = b.Replace(":43m", ".43m");
            b = b.Replace(":44m", ".44m");
            b = b.Replace(":45m", ".45m");
            b = b.Replace(":46m", ".46m");
            b = b.Replace(":47m", ".47m");
            b = b.Replace(":48m", ".48m");
            b = b.Replace(":49m", ".49m");
            b = b.Replace(":50m", ".50m");

            b = b.Replace(":51m", ".51m");
            b = b.Replace(":52m", ".52m");
            b = b.Replace(":53m", ".53m");
            b = b.Replace(":54m", ".54m");
            b = b.Replace(":55m", ".55m");
            b = b.Replace(":56m", ".56m");
            b = b.Replace(":57m", ".57m");
            b = b.Replace(":58m", ".58m");
            b = b.Replace(":59m", ".59m");
            b = b.Replace(":60m", ".60m");

            b = b.Replace(":61m", ".61m");
            b = b.Replace(":62m", ".62m");
            b = b.Replace(":63m", ".63m");
            b = b.Replace(":64m", ".64m");
            b = b.Replace(":65m", ".65m");
            b = b.Replace(":66m", ".66m");
            b = b.Replace(":67m", ".67m");
            b = b.Replace(":68m", ".68m");
            b = b.Replace(":69m", ".69m");
            b = b.Replace(":70m", ".70m");

            b = b.Replace(":71m", ".71m");
            b = b.Replace(":72m", ".72m");
            b = b.Replace(":73m", ".73m");
            b = b.Replace(":74m", ".74m");
            b = b.Replace(":75m", ".75m");
            b = b.Replace(":76m", ".76m");
            b = b.Replace(":77m", ".77m");
            b = b.Replace(":78m", ".78m");
            b = b.Replace(":79m", ".79m");
            b = b.Replace(":80m", ".80m");

            b = b.Replace(":81m", ".81m");
            b = b.Replace(":82m", ".82m");
            b = b.Replace(":83m", ".83m");
            b = b.Replace(":84m", ".84m");
            b = b.Replace(":85m", ".85m");
            b = b.Replace(":86m", ".86m");
            b = b.Replace(":87m", ".87m");
            b = b.Replace(":88m", ".88m");
            b = b.Replace(":89m", ".89m");
            b = b.Replace(":90m", ".90m");

            b = b.Replace(":91m", ".91m");
            b = b.Replace(":92m", ".92m");
            b = b.Replace(":93m", ".93m");
            b = b.Replace(":94m", ".94m");
            b = b.Replace(":95m", ".95m");
            b = b.Replace(":96m", ".96m");
            b = b.Replace(":97m", ".97m");
            b = b.Replace(":98m", ".98m");
            b = b.Replace(":99m", ".99m");

            b = b.Replace("m", "");

            b = b.Replace("__", ",");

            string mn = String.Concat(b, "m");

            b = b.Replace(":01m", ".01m");
            b = b.Replace(":02m", ".02m");
            b = b.Replace(":03m", ".03m");
            b = b.Replace(":04m", ".04m");
            b = b.Replace(":05m", ".05m");
            b = b.Replace(":06m", ".06m");
            b = b.Replace(":07m", ".07m");
            b = b.Replace(":08m", ".08m");
            b = b.Replace(":09m", ".09m");
            b = b.Replace(":10m", ".10m");

            b = b.Replace(":11m", ".11m");
            b = b.Replace(":12m", ".12m");
            b = b.Replace(":13m", ".13m");
            b = b.Replace(":14m", ".14m");
            b = b.Replace(":15m", ".15m");
            b = b.Replace(":16m", ".16m");
            b = b.Replace(":17m", ".17m");
            b = b.Replace(":18m", ".18m");
            b = b.Replace(":19m", ".19m");
            b = b.Replace(":20m", ".20m");

            b = b.Replace(":21m", ".21m");
            b = b.Replace(":22m", ".22m");
            b = b.Replace(":23m", ".23m");
            b = b.Replace(":24m", ".24m");
            b = b.Replace(":25m", ".25m");
            b = b.Replace(":26m", ".26m");
            b = b.Replace(":27m", ".27m");
            b = b.Replace(":28m", ".28m");
            b = b.Replace(":29m", ".29m");
            b = b.Replace(":30m", ".30m");

            b = b.Replace(":31m", ".31m");
            b = b.Replace(":32m", ".32m");
            b = b.Replace(":33m", ".33m");
            b = b.Replace(":34m", ".34m");
            b = b.Replace(":35m", ".35m");
            b = b.Replace(":36m", ".36m");
            b = b.Replace(":37m", ".37m");
            b = b.Replace(":38m", ".38m");
            b = b.Replace(":39m", ".39m");
            b = b.Replace(":40m", ".40m");

            b = b.Replace(":41m", ".41m");
            b = b.Replace(":42m", ".42m");
            b = b.Replace(":43m", ".43m");
            b = b.Replace(":44m", ".44m");
            b = b.Replace(":45m", ".45m");
            b = b.Replace(":46m", ".46m");
            b = b.Replace(":47m", ".47m");
            b = b.Replace(":48m", ".48m");
            b = b.Replace(":49m", ".49m");
            b = b.Replace(":50m", ".50m");

            b = b.Replace(":51m", ".51m");
            b = b.Replace(":52m", ".52m");
            b = b.Replace(":53m", ".53m");
            b = b.Replace(":54m", ".54m");
            b = b.Replace(":55m", ".55m");
            b = b.Replace(":56m", ".56m");
            b = b.Replace(":57m", ".57m");
            b = b.Replace(":58m", ".58m");
            b = b.Replace(":59m", ".59m");
            b = b.Replace(":60m", ".60m");

            b = b.Replace(":61m", ".61m");
            b = b.Replace(":62m", ".62m");
            b = b.Replace(":63m", ".63m");
            b = b.Replace(":64m", ".64m");
            b = b.Replace(":65m", ".65m");
            b = b.Replace(":66m", ".66m");
            b = b.Replace(":67m", ".67m");
            b = b.Replace(":68m", ".68m");
            b = b.Replace(":69m", ".69m");
            b = b.Replace(":70m", ".70m");

            b = b.Replace(":71m", ".71m");
            b = b.Replace(":72m", ".72m");
            b = b.Replace(":73m", ".73m");
            b = b.Replace(":74m", ".74m");
            b = b.Replace(":75m", ".75m");
            b = b.Replace(":76m", ".76m");
            b = b.Replace(":77m", ".77m");
            b = b.Replace(":78m", ".78m");
            b = b.Replace(":79m", ".79m");
            b = b.Replace(":80m", ".80m");

            b = b.Replace(":81m", ".81m");
            b = b.Replace(":82m", ".82m");
            b = b.Replace(":83m", ".83m");
            b = b.Replace(":84m", ".84m");
            b = b.Replace(":85m", ".85m");
            b = b.Replace(":86m", ".86m");
            b = b.Replace(":87m", ".87m");
            b = b.Replace(":88m", ".88m");
            b = b.Replace(":89m", ".89m");
            b = b.Replace(":90m", ".90m");

            b = b.Replace(":91m", ".91m");
            b = b.Replace(":92m", ".92m");
            b = b.Replace(":93m", ".93m");
            b = b.Replace(":94m", ".94m");
            b = b.Replace(":95m", ".95m");
            b = b.Replace(":96m", ".96m");
            b = b.Replace(":97m", ".97m");
            b = b.Replace(":98m", ".98m");
            b = b.Replace(":99m", ".99m");

            b = b.Replace("m", "");

            string cd = String.Concat(b, "p");

            cd = cd.Replace(":01p", ".01p");
            cd = cd.Replace(":02p", ".02p");
            cd = cd.Replace(":03p", ".03p");
            cd = cd.Replace(":04p", ".04p");
            cd = cd.Replace(":05p", ".05p");
            cd = cd.Replace(":06p", ".06p");
            cd = cd.Replace(":07p", ".07p");
            cd = cd.Replace(":08p", ".08p");
            cd = cd.Replace(":09p", ".09p");
            cd = cd.Replace(":10p", ".10p");

            cd = cd.Replace(":11p", ".11p");
            cd = cd.Replace(":12p", ".12p");
            cd = cd.Replace(":13p", ".13p");
            cd = cd.Replace(":14p", ".14p");
            cd = cd.Replace(":15p", ".15p");
            cd = cd.Replace(":16p", ".16p");
            cd = cd.Replace(":17p", ".17p");
            cd = cd.Replace(":18p", ".18p");
            cd = cd.Replace(":19p", ".19p");
            cd = cd.Replace(":20p", ".20p");

            cd = cd.Replace(":21p", ".21p");
            cd = cd.Replace(":22p", ".22p");
            cd = cd.Replace(":23p", ".23p");
            cd = cd.Replace(":24p", ".24p");
            cd = cd.Replace(":25p", ".25p");
            cd = cd.Replace(":26p", ".26p");
            cd = cd.Replace(":27p", ".27p");
            cd = cd.Replace(":28p", ".28p");
            cd = cd.Replace(":29p", ".29p");
            cd = cd.Replace(":30p", ".30p");

            cd = cd.Replace(":31p", ".31p");
            cd = cd.Replace(":32p", ".32p");
            cd = cd.Replace(":33p", ".33p");
            cd = cd.Replace(":34p", ".34p");
            cd = cd.Replace(":35p", ".35p");
            cd = cd.Replace(":36p", ".36p");
            cd = cd.Replace(":37p", ".37p");
            cd = cd.Replace(":38p", ".38p");
            cd = cd.Replace(":39p", ".39p");
            cd = cd.Replace(":40p", ".40p");

            cd = cd.Replace(":41p", ".41p");
            cd = cd.Replace(":42p", ".42p");
            cd = cd.Replace(":43p", ".43p");
            cd = cd.Replace(":44p", ".44p");
            cd = cd.Replace(":45p", ".45p");
            cd = cd.Replace(":46p", ".46p");
            cd = cd.Replace(":47p", ".47p");
            cd = cd.Replace(":48p", ".48p");
            cd = cd.Replace(":49p", ".49p");
            cd = cd.Replace(":50p", ".50p");

            cd = cd.Replace(":51p", ".51p");
            cd = cd.Replace(":52p", ".52p");
            cd = cd.Replace(":53p", ".53p");
            cd = cd.Replace(":54p", ".54p");
            cd = cd.Replace(":55p", ".55p");
            cd = cd.Replace(":56p", ".56p");
            cd = cd.Replace(":57p", ".57p");
            cd = cd.Replace(":58p", ".58p");
            cd = cd.Replace(":59p", ".59p");
            cd = cd.Replace(":60p", ".60p");

            cd = cd.Replace(":61p", ".61p");
            cd = cd.Replace(":62p", ".62p");
            cd = cd.Replace(":63p", ".63p");
            cd = cd.Replace(":64p", ".64p");
            cd = cd.Replace(":65p", ".65p");
            cd = cd.Replace(":66p", ".66p");
            cd = cd.Replace(":67p", ".67p");
            cd = cd.Replace(":68p", ".68p");
            cd = cd.Replace(":69p", ".69p");
            cd = cd.Replace(":70p", ".70p");

            cd = cd.Replace(":71p", ".71p");
            cd = cd.Replace(":72p", ".72p");
            cd = cd.Replace(":73p", ".73p");
            cd = cd.Replace(":74p", ".74p");
            cd = cd.Replace(":75p", ".75p");
            cd = cd.Replace(":76p", ".76p");
            cd = cd.Replace(":77p", ".77p");
            cd = cd.Replace(":78p", ".78p");
            cd = cd.Replace(":79p", ".79p");
            cd = cd.Replace(":80p", ".80p");

            cd = cd.Replace(":81p", ".81p");
            cd = cd.Replace(":82p", ".82p");
            cd = cd.Replace(":83p", ".83p");
            cd = cd.Replace(":84p", ".84p");
            cd = cd.Replace(":85p", ".85p");
            cd = cd.Replace(":86p", ".86p");
            cd = cd.Replace(":87p", ".87p");
            cd = cd.Replace(":88p", ".88p");
            cd = cd.Replace(":89p", ".89p");
            cd = cd.Replace(":90p", ".90p");

            cd = cd.Replace(":91p", ".91p");
            cd = cd.Replace(":92p", ".92p");
            cd = cd.Replace(":93p", ".93p");
            cd = cd.Replace(":94p", ".94p");
            cd = cd.Replace(":95p", ".95p");
            cd = cd.Replace(":96p", ".96p");
            cd = cd.Replace(":97p", ".97p");
            cd = cd.Replace(":98p", ".98p");
            cd = cd.Replace(":99p", ".99p");

            cd = cd.Replace("p", "");

            string ser = "Dialogue: 0,";
            string ser2 = ",Default,,0,0,0,,";
            string ser3 = String.Concat(ser, cd);
            string ser4 = String.Concat(ser3, ser2);
            string ser5 = String.Concat(ser4, subfile[bot]);

            File.AppendAllText(gorn, ser5 + Environment.NewLine);
            do
            {
                bot += 1;

                string c = timingFile[bot];


                //string c = String.Concat(timingFile[bot], subfile[bot]);

                c = c.Replace("0.jpeg", "m");
                c = c.Replace("1.jpeg", "m");
                c = c.Replace("2.jpeg", "m");
                c = c.Replace("3.jpeg", "m");
                c = c.Replace("4.jpeg", "m");
                c = c.Replace("5.jpeg", "m");
                c = c.Replace("6.jpeg", "m");
                c = c.Replace("7.jpeg", "m");
                c = c.Replace("8.jpeg", "m");
                c = c.Replace("9.jpeg", "m");

                c = c.Replace("0__0", ",0");
                c = c.Replace("1__0", ",0");
                c = c.Replace("2__0", ",0");
                c = c.Replace("3__0", ",0");
                c = c.Replace("4__0", ",0");
                c = c.Replace("5__0", ",0");
                c = c.Replace("6__0", ",0");
                c = c.Replace("7__0", ",0");
                c = c.Replace("8__0", ",0");
                c = c.Replace("9__0", ",0");

                c = c.Replace("0__1", ",0");
                c = c.Replace("0__2", ",0");
                c = c.Replace("0__3", ",0");
                c = c.Replace("0__4", ",0");
                c = c.Replace("0__5", ",0");
                c = c.Replace("0__6", ",0");
                c = c.Replace("0__7", ",0");
                c = c.Replace("0__8", ",0");
                c = c.Replace("0__9", ",0");

                c = c.Replace("1__1", ",0");
                c = c.Replace("2__2", ",0");
                c = c.Replace("3__3", ",0");
                c = c.Replace("4__4", ",0");
                c = c.Replace("5__5", ",0");
                c = c.Replace("6__6", ",0");
                c = c.Replace("7__7", ",0");
                c = c.Replace("8__8", ",0");
                c = c.Replace("9__9", ",0");

                c = c.Replace("1__2", ",0");
                c = c.Replace("1__3", ",0");
                c = c.Replace("1__4", ",0");
                c = c.Replace("1__5", ",0");
                c = c.Replace("1__6", ",0");
                c = c.Replace("1__7", ",0");
                c = c.Replace("1__8", ",0");
                c = c.Replace("1__9", ",0");

                c = c.Replace("2__1", ",0");
                c = c.Replace("3__1", ",0");
                c = c.Replace("4__1", ",0");
                c = c.Replace("5__1", ",0");
                c = c.Replace("6__1", ",0");
                c = c.Replace("7__1", ",0");
                c = c.Replace("8__1", ",0");
                c = c.Replace("9__1", ",0");

                c = c.Replace("2__3", ",0");
                c = c.Replace("2__4", ",0");
                c = c.Replace("2__5", ",0");
                c = c.Replace("2__6", ",0");
                c = c.Replace("2__7", ",0");
                c = c.Replace("2__8", ",0");
                c = c.Replace("2__9", ",0");

                c = c.Replace("3__2", ",0");
                c = c.Replace("4__2", ",0");
                c = c.Replace("5__2", ",0");
                c = c.Replace("6__2", ",0");
                c = c.Replace("7__2", ",0");
                c = c.Replace("8__2", ",0");
                c = c.Replace("9__2", ",0");

                c = c.Replace("3__4", ",0");
                c = c.Replace("3__5", ",0");
                c = c.Replace("3__6", ",0");
                c = c.Replace("3__7", ",0");
                c = c.Replace("3__8", ",0");
                c = c.Replace("3__9", ",0");

                c = c.Replace("4__3", ",0");
                c = c.Replace("5__3", ",0");
                c = c.Replace("6__3", ",0");
                c = c.Replace("7__3", ",0");
                c = c.Replace("8__3", ",0");
                c = c.Replace("9__3", ",0");

                c = c.Replace("4__5", ",0");
                c = c.Replace("4__6", ",0");
                c = c.Replace("4__7", ",0");
                c = c.Replace("4__8", ",0");
                c = c.Replace("4__9", ",0");

                c = c.Replace("5__4", ",0");
                c = c.Replace("6__4", ",0");
                c = c.Replace("7__4", ",0");
                c = c.Replace("8__4", ",0");
                c = c.Replace("9__4", ",0");

                c = c.Replace("5__6", ",0");
                c = c.Replace("5__7", ",0");
                c = c.Replace("5__8", ",0");
                c = c.Replace("5__9", ",0");

                c = c.Replace("6__5", ",0");
                c = c.Replace("7__5", ",0");
                c = c.Replace("8__5", ",0");
                c = c.Replace("9__5", ",0");

                c = c.Replace("6__7", ",0");
                c = c.Replace("6__8", ",0");
                c = c.Replace("6__9", ",0");

                c = c.Replace("7__6", ",0");
                c = c.Replace("8__6", ",0");
                c = c.Replace("9__6", ",0");


                c = c.Replace("7__8", ",0");
                c = c.Replace("7__9", ",0");

                c = c.Replace("8__7", ",0");
                c = c.Replace("9__7", ",0");


                c = c.Replace("8__9", ",0");

                c = c.Replace("9__8", ",0");

                c = c.Replace("_00,", ".00,");
                c = c.Replace("_01,", ".01,");
                c = c.Replace("_02,", ".02,");
                c = c.Replace("_03,", ".03,");
                c = c.Replace("_04,", ".04,");
                c = c.Replace("_05,", ".05,");
                c = c.Replace("_06,", ".06,");
                c = c.Replace("_07,", ".07,");
                c = c.Replace("_08,", ".08,");
                c = c.Replace("_09,", ".09,");
                c = c.Replace("_10,", ".10,");

                c = c.Replace("_11,", ".11,");
                c = c.Replace("_12,", ".12,");
                c = c.Replace("_13,", ".13,");
                c = c.Replace("_14,", ".14,");
                c = c.Replace("_15,", ".15,");
                c = c.Replace("_16,", ".16,");
                c = c.Replace("_17,", ".17,");
                c = c.Replace("_18,", ".18,");
                c = c.Replace("_19,", ".19,");

                c = c.Replace("_20,", ".20,");
                c = c.Replace("_21,", ".21,");
                c = c.Replace("_22,", ".22,");
                c = c.Replace("_23,", ".23,");
                c = c.Replace("_24,", ".24,");
                c = c.Replace("_25,", ".25,");
                c = c.Replace("_26,", ".26,");
                c = c.Replace("_27,", ".27,");
                c = c.Replace("_28,", ".28,");
                c = c.Replace("_29,", ".29,");
                c = c.Replace("_30,", ".30,");

                c = c.Replace("_31,", ".31,");
                c = c.Replace("_32,", ".32,");
                c = c.Replace("_33,", ".33,");
                c = c.Replace("_34,", ".34,");
                c = c.Replace("_35,", ".35,");
                c = c.Replace("_36,", ".36,");
                c = c.Replace("_37,", ".37,");
                c = c.Replace("_38,", ".38,");
                c = c.Replace("_39,", ".39,");
                c = c.Replace("_40,", ".40,");

                c = c.Replace("_41,", ".41,");
                c = c.Replace("_42,", ".42,");
                c = c.Replace("_43,", ".43,");
                c = c.Replace("_44,", ".44,");
                c = c.Replace("_45,", ".45,");
                c = c.Replace("_46,", ".46,");
                c = c.Replace("_47,", ".47,");
                c = c.Replace("_48,", ".48,");
                c = c.Replace("_49,", ".49,");
                c = c.Replace("_50,", ".50,");

                c = c.Replace("_51,", ".51,");
                c = c.Replace("_52,", ".52,");
                c = c.Replace("_53,", ".53,");
                c = c.Replace("_54,", ".54,");
                c = c.Replace("_55,", ".55,");
                c = c.Replace("_56,", ".56,");
                c = c.Replace("_57,", ".57,");
                c = c.Replace("_58,", ".58,");
                c = c.Replace("_59,", ".59,");
                c = c.Replace("_60,", ".60,");

                c = c.Replace("_61,", ".61,");
                c = c.Replace("_62,", ".62,");
                c = c.Replace("_63,", ".63,");
                c = c.Replace("_64,", ".64,");
                c = c.Replace("_65,", ".65,");
                c = c.Replace("_66,", ".66,");
                c = c.Replace("_67,", ".67,");
                c = c.Replace("_68,", ".68,");
                c = c.Replace("_69,", ".69,");
                c = c.Replace("_70,", ".70,");

                c = c.Replace("_71,", ".71,");
                c = c.Replace("_72,", ".72,");
                c = c.Replace("_73,", ".73,");
                c = c.Replace("_74,", ".74,");
                c = c.Replace("_75,", ".75,");
                c = c.Replace("_76,", ".76,");
                c = c.Replace("_77,", ".77,");
                c = c.Replace("_78,", ".78,");
                c = c.Replace("_79,", ".79,");
                c = c.Replace("_80,", ".80,");

                c = c.Replace("_81,", ".81,");
                c = c.Replace("_82,", ".82,");
                c = c.Replace("_83,", ".83,");
                c = c.Replace("_84,", ".84,");
                c = c.Replace("_85,", ".85,");
                c = c.Replace("_86,", ".86,");
                c = c.Replace("_87,", ".87,");
                c = c.Replace("_88,", ".88,");
                c = c.Replace("_89,", ".89,");
                c = c.Replace("_90,", ".90,");

                c = c.Replace("_91,", ".91,");
                c = c.Replace("_92,", ".92,");
                c = c.Replace("_93,", ".93,");
                c = c.Replace("_94,", ".94,");
                c = c.Replace("_95,", ".95,");
                c = c.Replace("_96,", ".96,");
                c = c.Replace("_97,", ".97,");
                c = c.Replace("_98,", ".98,");
                c = c.Replace("_99,", ".99,");

                c = c.Replace("_", ":");

                c = c.Replace(":01m", ".01m");
                c = c.Replace(":02m", ".02m");
                c = c.Replace(":03m", ".03m");
                c = c.Replace(":04m", ".04m");
                c = c.Replace(":05m", ".05m");
                c = c.Replace(":06m", ".06m");
                c = c.Replace(":07m", ".07m");
                c = c.Replace(":08m", ".08m");
                c = c.Replace(":09m", ".09m");
                c = c.Replace(":10m", ".10m");

                c = c.Replace(":11m", ".11m");
                c = c.Replace(":12m", ".12m");
                c = c.Replace(":13m", ".13m");
                c = c.Replace(":14m", ".14m");
                c = c.Replace(":15m", ".15m");
                c = c.Replace(":16m", ".16m");
                c = c.Replace(":17m", ".17m");
                c = c.Replace(":18m", ".18m");
                c = c.Replace(":19m", ".19m");
                c = c.Replace(":20m", ".20m");

                c = c.Replace(":21m", ".21m");
                c = c.Replace(":22m", ".22m");
                c = c.Replace(":23m", ".23m");
                c = c.Replace(":24m", ".24m");
                c = c.Replace(":25m", ".25m");
                c = c.Replace(":26m", ".26m");
                c = c.Replace(":27m", ".27m");
                c = c.Replace(":28m", ".28m");
                c = c.Replace(":29m", ".29m");
                c = c.Replace(":30m", ".30m");

                c = c.Replace(":31m", ".31m");
                c = c.Replace(":32m", ".32m");
                c = c.Replace(":33m", ".33m");
                c = c.Replace(":34m", ".34m");
                c = c.Replace(":35m", ".35m");
                c = c.Replace(":36m", ".36m");
                c = c.Replace(":37m", ".37m");
                c = c.Replace(":38m", ".38m");
                c = c.Replace(":39m", ".39m");
                c = c.Replace(":40m", ".40m");

                c = c.Replace(":41m", ".41m");
                c = c.Replace(":42m", ".42m");
                c = c.Replace(":43m", ".43m");
                c = c.Replace(":44m", ".44m");
                c = c.Replace(":45m", ".45m");
                c = c.Replace(":46m", ".46m");
                c = c.Replace(":47m", ".47m");
                c = c.Replace(":48m", ".48m");
                c = c.Replace(":49m", ".49m");
                c = c.Replace(":50m", ".50m");

                c = c.Replace(":51m", ".51m");
                c = c.Replace(":52m", ".52m");
                c = c.Replace(":53m", ".53m");
                c = c.Replace(":54m", ".54m");
                c = c.Replace(":55m", ".55m");
                c = c.Replace(":56m", ".56m");
                c = c.Replace(":57m", ".57m");
                c = c.Replace(":58m", ".58m");
                c = c.Replace(":59m", ".59m");
                c = c.Replace(":60m", ".60m");

                c = c.Replace(":61m", ".61m");
                c = c.Replace(":62m", ".62m");
                c = c.Replace(":63m", ".63m");
                c = c.Replace(":64m", ".64m");
                c = c.Replace(":65m", ".65m");
                c = c.Replace(":66m", ".66m");
                c = c.Replace(":67m", ".67m");
                c = c.Replace(":68m", ".68m");
                c = c.Replace(":69m", ".69m");
                c = c.Replace(":70m", ".70m");

                c = c.Replace(":71m", ".71m");
                c = c.Replace(":72m", ".72m");
                c = c.Replace(":73m", ".73m");
                c = c.Replace(":74m", ".74m");
                c = c.Replace(":75m", ".75m");
                c = c.Replace(":76m", ".76m");
                c = c.Replace(":77m", ".77m");
                c = c.Replace(":78m", ".78m");
                c = c.Replace(":79m", ".79m");
                c = c.Replace(":80m", ".80m");

                c = c.Replace(":81m", ".81m");
                c = c.Replace(":82m", ".82m");
                c = c.Replace(":83m", ".83m");
                c = c.Replace(":84m", ".84m");
                c = c.Replace(":85m", ".85m");
                c = c.Replace(":86m", ".86m");
                c = c.Replace(":87m", ".87m");
                c = c.Replace(":88m", ".88m");
                c = c.Replace(":89m", ".89m");
                c = c.Replace(":90m", ".90m");

                c = c.Replace(":91m", ".91m");
                c = c.Replace(":92m", ".92m");
                c = c.Replace(":93m", ".93m");
                c = c.Replace(":94m", ".94m");
                c = c.Replace(":95m", ".95m");
                c = c.Replace(":96m", ".96m");
                c = c.Replace(":97m", ".97m");
                c = c.Replace(":98m", ".98m");
                c = c.Replace(":99m", ".99m");

                c = c.Replace("m", "");

                string ser6 = "Dialogue: 0,";
                string ser7 = ",Default,,0,0,0,,";
                string ser8 = String.Concat(ser6, c);
                string ser9 = String.Concat(ser8, ser7);
                string ser10 = String.Concat(ser9, subfile[bot]);


                File.AppendAllText(gorn, ser10 + Environment.NewLine);
                

            } while (bot != opa);
                


            


        }

        private void СоздатьПапкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var list = CreateFoldersList();
            foreach (var dir6 in list)
            {
                Directory.CreateDirectory(dir6);
            }


        }

        private void ОчиститьПапкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = CreateFoldersList();
            foreach (var dir7 in list)
            {
                Directory.Delete(dir7, true);
                Directory.CreateDirectory(dir7);

                string folderA = String.Concat(textBox2.Text, "\\a");
                string folderA2 = String.Concat(textBox2.Text, "\\a2");
                string folderA3 = String.Concat(textBox2.Text, "\\a3");
                string folderA4 = String.Concat(textBox2.Text, "\\a4");
                string folderB = String.Concat(textBox2.Text, "\\b");
                string folderB2 = String.Concat(textBox2.Text, "\\b2");
                string folderB3 = String.Concat(textBox2.Text, "\\b3");
                string folderB4 = String.Concat(textBox2.Text, "\\b4");
                string folderC = String.Concat(textBox2.Text, "\\c");
                string folderC2 = String.Concat(textBox2.Text, "\\c2");
                string folderC3 = String.Concat(textBox2.Text, "\\c3");
                string folderC4 = String.Concat(textBox2.Text, "\\c4");
                string folderD = String.Concat(textBox2.Text, "\\d");
                string folderD2 = String.Concat(textBox2.Text, "\\d2");
                string folderD3 = String.Concat(textBox2.Text, "\\d3");
                string folderD4 = String.Concat(textBox2.Text, "\\d4");
                string folderF = String.Concat(textBox2.Text, "\\f");
                string folderF2 = String.Concat(textBox2.Text, "\\f2");
                string folderF3 = String.Concat(textBox2.Text, "\\f3");
                string folderF4 = String.Concat(textBox2.Text, "\\f4");




                if (!Directory.Exists(folderA))
                {
                    Directory.CreateDirectory(folderA);
                }

                if (!Directory.Exists(folderA2))
                {
                    Directory.CreateDirectory(folderA2);
                }

                if (!Directory.Exists(folderA3))
                {
                    Directory.CreateDirectory(folderA3);
                }

                if (!Directory.Exists(folderA4))
                {
                    Directory.CreateDirectory(folderA4);
                }

                if (!Directory.Exists(folderB))
                {
                    Directory.CreateDirectory(folderB);
                }

                if (!Directory.Exists(folderB2))
                {
                    Directory.CreateDirectory(folderB2);
                }

                if (!Directory.Exists(folderB3))
                {
                    Directory.CreateDirectory(folderB3);
                }

                if (!Directory.Exists(folderB4))
                {
                    Directory.CreateDirectory(folderB4);
                }

                if (!Directory.Exists(folderC))
                {
                    Directory.CreateDirectory(folderC);
                }

                if (!Directory.Exists(folderC2))
                {
                    Directory.CreateDirectory(folderC2);
                }

                if (!Directory.Exists(folderC3))
                {
                    Directory.CreateDirectory(folderC3);
                }

                if (!Directory.Exists(folderC4))
                {
                    Directory.CreateDirectory(folderC4);
                }

                if (!Directory.Exists(folderD))
                {
                    Directory.CreateDirectory(folderD);
                }

                if (!Directory.Exists(folderD2))
                {
                    Directory.CreateDirectory(folderD2);
                }

                if (!Directory.Exists(folderD3))
                {
                    Directory.CreateDirectory(folderD3);
                }

                if (!Directory.Exists(folderD4))
                {
                    Directory.CreateDirectory(folderD4);
                }

                if (!Directory.Exists(folderF))
                {
                    Directory.CreateDirectory(folderF);
                }

                if (!Directory.Exists(folderF2))
                {
                    Directory.CreateDirectory(folderF2);
                }

                if (!Directory.Exists(folderF3))
                {
                    Directory.CreateDirectory(folderF3);
                }

                if (!Directory.Exists(folderF4))
                {
                    Directory.CreateDirectory(folderF4);
                }



            }
        }

        private void ВосстановитьУмолчанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = CreateFoldersList();
            foreach (var dir6 in list)
            {
                Directory.Delete(dir6, true);
            }

            string a = "\\Timing.txt";
            string b = "\\TimingAndPaths.txt";
            string c = "\\ReadMe.txt";
            string d = "\\renameSn.txt";
            string f = "\\sub.txt";


            string ab = String.Concat(textBox3.Text, a);
            string be = String.Concat(textBox3.Text, b);
            string ct = String.Concat(textBox3.Text, c);
            string dt = String.Concat(textBox3.Text, d);
            string dg = String.Concat(textBox3.Text, f);


            if (File.Exists(ab))
            {
                File.Delete(ab);
            }

            if (File.Exists(be))
            {
                File.Delete(be);
            }

            if (File.Exists(ct))
            {
                File.Delete(ct);
            }

            if (File.Exists(dt))
            {
                File.Delete(dt);
            }

            if (File.Exists(dg))
            {
                File.Delete(dg);
            }

            

            for (int i = 1, r = 81; i != r; i++)
            {
                string nn1 = textBox3.Text;
                string nn2 = "\\0";
                string nn3 = "_newname.docx";
                string nn4 = String.Concat(nn1, nn2);
                string nn5 = String.Concat(nn4, i);
                string nn6 = String.Concat(nn5, nn3);

                if(File.Exists(nn6))
                {
                    File.Delete(nn6);
                }
            }

            for (int u = 2, y = 81; u != y; u++)
            {
                string nn7 = textBox3.Text;
                string nn8 = "\\MergedFile";
                string nn9 = ".docx";
                string nn10 = String.Concat(nn7, nn8);
                string nn11 = String.Concat(nn10, u);
                string nn12 = String.Concat(nn11, nn9);

                if (File.Exists(nn12))
                {
                    File.Delete(nn12);
                }
            }

        

        }

        private void ПолучитьbatФайлыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<string> RenameLinesList()
            {
                return new List<string>()
                {
                    $"{"@echo off"}",
                    $"{"setlocal"}" + Environment.NewLine,
                    $"{"for %%i in (*.docx) do call:rename \"%%i\""}",
                    $"{"goto:eof"}" + Environment.NewLine,
                    $"{":rename"}",
                    $"{"set /a cnt+=1"}",
                    $"{"set \"pref=0%cnt%\""}",
                    $"{"ren %1 \"%pref:~-5%_newname.docx\""}",

                };
            }


            string T = "\\renameSn.txt";
            string Stringi = String.Concat(textBox3.Text, T);            


                    //"@\"E:\\RGBImages\\01_newname.jpeg\"";

                    var list = RenameLinesList();
                    foreach (var dir6 in list)
                    {
                        File.AppendAllText(Stringi, dir6 + Environment.NewLine);
                    }
                    
                    MessageBox.Show("Для переименования ваших документов смените расширение файла renameSn на .bat и запустите его");
          
            
        }

        private void СкопироватьФоткиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Получаем абсолютные пути фоток, которые находятся в указанной папке
            string[] fileslist = Directory.GetFiles(textBox1.Text);

            //Получаем части путей для перемещения
            string upk = textBox2.Text;
            string upk1 = "\\a\\";
            string upk2 = "\\a2\\";
            string upk3 = "\\a3\\";
            string upk4 = "\\a4\\";
            string upk5 = "\\b\\";
            string upk6 = "\\b2\\";
            string upk7 = "\\b3\\";
            string upk8 = "\\b4\\";
            string upk9 = "\\c\\";
            string upk10 = "\\c2\\";
            string upk11 = "\\c3\\";
            string upk12 = "\\c4\\";
            string upk13 = "\\d\\";
            string upk14 = "\\d2\\";
            string upk15 = "\\d3\\";
            string upk16 = "\\d4\\";
            string upk17 = "\\f\\";
            string upk18 = "\\f2\\";
            string upk19 = "\\f3\\";
            string upk20 = "\\f4\\";

            //Объединяем каждую папку из списка с путём textBox2.Text (По этому пути будут созданы указанные папки)
            string[] jake = new string[20];
            jake[0] = String.Concat(upk, upk1);
            jake[1] = String.Concat(upk, upk2);
            jake[2] = String.Concat(upk, upk3);
            jake[3] = String.Concat(upk, upk4);
            jake[4] = String.Concat(upk, upk5);
            jake[5] = String.Concat(upk, upk6);
            jake[6] = String.Concat(upk, upk7);
            jake[7] = String.Concat(upk, upk8);
            jake[8] = String.Concat(upk, upk9);
            jake[9] = String.Concat(upk, upk10);
            jake[10] = String.Concat(upk, upk11);
            jake[11] = String.Concat(upk, upk12);
            jake[12] = String.Concat(upk, upk13);
            jake[13] = String.Concat(upk, upk14);
            jake[14] = String.Concat(upk, upk15);
            jake[15] = String.Concat(upk, upk16);
            jake[16] = String.Concat(upk, upk17);
            jake[17] = String.Concat(upk, upk18);
            jake[18] = String.Concat(upk, upk19);
            jake[19] = String.Concat(upk, upk20);



            if (radioButton1.Checked == true)
            {
                string file = "\\Timing.txt";
                string Read = String.Concat(textBox3.Text, file);

                if (File.Exists(Read))
                    {
                        string[] timingTxT = File.ReadAllLines(Read);
                        int Length = timingTxT.Length;



                        for (int a = 0; a <= 49 && a < Length; a++)
                        {
                            string moveRestFiles = String.Concat(jake[0], timingTxT[a]);
                            if (File.Exists(fileslist[a]))
                            {
                                File.Copy(fileslist[a], moveRestFiles);
                            }

                            
                        }

                        for (int b = 50; b <= 99 && b < Length; b++)
                        {
                            string moveRestFiles = String.Concat(jake[1], timingTxT[b]);
                            if (File.Exists(fileslist[b]))
                            {
                                File.Copy(fileslist[b], moveRestFiles);
                            }

                            
                        }

                        for (int c = 100; c < 150 && c < Length; c++)
                        {
                            string moveRestFiles = String.Concat(jake[2], timingTxT[c]);
                            if (File.Exists(fileslist[c]))
                            {
                                File.Copy(fileslist[c], moveRestFiles);
                            }

                           
                        }

                        for (int d = 150; d < 200 && d < Length; d++)
                        {
                            string moveRestFiles = String.Concat(jake[3], timingTxT[d]);
                            if (File.Exists(fileslist[d]))
                            {
                                File.Copy(fileslist[d], moveRestFiles);
                            }

                            
                        }

                        for (int f = 200; f < 250 && f < Length; f++)
                        {
                            string moveRestFiles = String.Concat(jake[4], timingTxT[f]);
                            if (File.Exists(fileslist[f]))
                            {
                                File.Copy(fileslist[f], moveRestFiles);
                            }

                           
                        }

                        for (int aa = 250; aa < 300 && aa < Length; aa++)
                        {
                            string moveRestFiles = String.Concat(jake[5], timingTxT[aa]);
                            if (File.Exists(fileslist[aa]))
                            {
                                File.Copy(fileslist[aa], moveRestFiles);
                            }

                            
                        }

                        for (int bb = 300; bb < 350 && bb < Length; bb++)
                        {
                            string moveRestFiles = String.Concat(jake[6], timingTxT[bb]);
                            if (File.Exists(fileslist[bb]))
                            {
                                File.Copy(fileslist[bb], moveRestFiles);
                            }

                           
                        }

                        for (int cc = 350; cc < 400 && cc < Length; cc++)
                        {
                            string moveRestFiles = String.Concat(jake[7], timingTxT[cc]);
                            if (File.Exists(fileslist[cc]))
                            {
                                File.Copy(fileslist[cc], moveRestFiles);
                            }

                            
                        }

                        for (int dd = 400; dd < 450 && dd < Length; dd++)
                        {
                            string moveRestFiles = String.Concat(jake[8], timingTxT[dd]);
                            if (File.Exists(fileslist[dd]))
                            {
                                File.Copy(fileslist[dd], moveRestFiles);
                            }

                            
                        }

                        for (int ff = 450; ff < 500 && ff < Length; ff++)
                        {
                            string moveRestFiles = String.Concat(jake[9], timingTxT[ff]);
                            if (File.Exists(fileslist[ff]))
                            {
                                File.Copy(fileslist[ff], moveRestFiles);
                            }

                            
                        }

                        for (int fa = 500; fa < 550 && fa < Length; fa++)
                        {
                            string moveRestFiles = String.Concat(jake[10], timingTxT[fa]);
                            if (File.Exists(fileslist[fa]))
                            {
                                File.Copy(fileslist[fa], moveRestFiles);
                            }

                            
                        }

                        for (int fe = 550; fe < 600 && fe < Length; fe++)
                        {
                            string moveRestFiles = String.Concat(jake[11], timingTxT[fe]);
                            if (File.Exists(fileslist[fe]))
                            {
                                File.Copy(fileslist[fe], moveRestFiles);
                            }

                            
                        }

                        for (int fr = 600; fr < 650 && fr < Length; fr++)
                        {
                            string moveRestFiles = String.Concat(jake[12], timingTxT[fr]);
                            if (File.Exists(fileslist[fr]))
                            {
                                File.Copy(fileslist[fr], moveRestFiles);
                            }

                            
                        }

                        for (int fq = 650; fq < 700 && fq < Length; fq++)
                        {
                            string moveRestFiles = String.Concat(jake[13], timingTxT[fq]);
                            if (File.Exists(fileslist[fq]))
                            {
                                File.Copy(fileslist[fq], moveRestFiles);
                            }

                            
                        }

                        for (int fk = 700; fk < 750 && fk < Length; fk++)
                        {
                            string moveRestFiles = String.Concat(jake[14], timingTxT[fk]);
                            if (File.Exists(fileslist[fk]))
                            {
                                File.Copy(fileslist[fk], moveRestFiles);
                            }

                            
                        }

                        for (int fj = 750; fj < 800 && fj < Length; fj++)
                        {
                            string moveRestFiles = String.Concat(jake[15], timingTxT[fj]);
                            if (File.Exists(fileslist[fj]))
                            {
                                File.Copy(fileslist[fj], moveRestFiles);
                            }

                            
                        }

                        for (int fh = 800; fh < 850 && fh < Length; fh++)
                        {
                            string moveRestFiles = String.Concat(jake[16], timingTxT[fh]);
                            if (File.Exists(fileslist[fh]))
                            {
                                File.Copy(fileslist[fh], moveRestFiles);
                            }

                           
                        }

                        for (int fw = 850; fw < 900 && fw < Length; fw++)
                        {
                            string moveRestFiles = String.Concat(jake[17], timingTxT[fw]);
                            if (File.Exists(fileslist[fw]))
                            {
                                File.Copy(fileslist[fw], moveRestFiles);
                            }

                            
                        }

                        for (int fd = 900; fd < 950 && fd < Length; fd++)
                        {
                            string moveRestFiles = String.Concat(jake[18], timingTxT[fd]);
                            if (File.Exists(fileslist[fd]))
                            {
                                File.Copy(fileslist[fd], moveRestFiles);
                            }

                            
                        }

                        for (int eu = 950; eu < 1000 && eu < Length; eu++)
                        {
                            string moveRestFiles = String.Concat(jake[19], timingTxT[eu]);
                            if (File.Exists(fileslist[eu]))
                            {
                                File.Copy(fileslist[eu], moveRestFiles);
                            }

                            
                        }



                }
                
            }

            if (radioButton2.Checked == true)
            {
                string file = "\\Timing.txt";
                string Read = String.Concat(textBox3.Text, file);


                if (File.Exists(Read))
                    {
                        string[] timingTxT = File.ReadAllLines(Read);
                        int length = timingTxT.Length;


                        for (int a = 1000; a < 1050 && a < length; a++)
                        {
                            string moveRestFiles = String.Concat(jake[0], timingTxT[a]);
                            if (File.Exists(fileslist[a]))
                            {
                                File.Copy(fileslist[a], moveRestFiles);
                            }

                            
                        }

                        for (int b = 1050; b < 1100 && b < length; b++)
                        {
                            string moveRestFiles = String.Concat(jake[1], timingTxT[b]);
                            if (File.Exists(fileslist[b]))
                            {
                                File.Copy(fileslist[b], moveRestFiles);
                            }

                            
                        }

                        for (int c = 1100; c < 1150 && c < length; c++)
                        {
                            string moveRestFiles = String.Concat(jake[2], timingTxT[c]);
                            if (File.Exists(fileslist[c]))
                            {
                                File.Copy(fileslist[c], moveRestFiles);
                            }

                            
                        }

                        for (int d = 1150; d < 1200 && d < length; d++)
                        {
                            string moveRestFiles = String.Concat(jake[3], timingTxT[d]);
                            if (File.Exists(fileslist[d]))
                            {
                                File.Copy(fileslist[d], moveRestFiles);
                            }

                            
                        }

                        for (int f = 1200; f < 1250 && f < length; f++)
                        {
                            string moveRestFiles = String.Concat(jake[4], timingTxT[f]);
                            if (File.Exists(fileslist[f]))
                            {
                                File.Copy(fileslist[f], moveRestFiles);
                            }

                            
                        }

                        for (int aa = 1250; aa < 1300 && aa < length; aa++)
                        {
                            string moveRestFiles = String.Concat(jake[5], timingTxT[aa]);
                            if (File.Exists(fileslist[aa]))
                            {
                                File.Copy(fileslist[aa], moveRestFiles);
                            }

                            
                        }

                        for (int bb = 1300; bb < 1350 && bb < length; bb++)
                        {
                            string moveRestFiles = String.Concat(jake[6], timingTxT[bb]);
                            if (File.Exists(fileslist[bb]))
                            {
                                File.Copy(fileslist[bb], moveRestFiles);
                            }

                            
                        }

                        for (int cc = 1350; cc < 1400 && cc < length; cc++)
                        {
                            string moveRestFiles = String.Concat(jake[7], timingTxT[cc]);
                            if (File.Exists(fileslist[cc]))
                            {
                                File.Copy(fileslist[cc], moveRestFiles);
                            }

                           
                        }

                        for (int dd = 1400; dd < 1450 && dd < length; dd++)
                        {
                            string moveRestFiles = String.Concat(jake[8], timingTxT[dd]);
                            if (File.Exists(fileslist[dd]))
                            {
                                File.Copy(fileslist[dd], moveRestFiles);
                            }

                            
                        }

                        for (int ff = 1450; ff < 1500 && ff < length; ff++)
                        {
                            string moveRestFiles = String.Concat(jake[9], timingTxT[ff]);
                            if (File.Exists(fileslist[ff]))
                            {
                                File.Copy(fileslist[ff], moveRestFiles);
                            }

                            
                        }

                        for (int fa = 1500; fa < 1550 && fa < length; fa++)
                        {
                            string moveRestFiles = String.Concat(jake[10], timingTxT[fa]);
                            if (File.Exists(fileslist[fa]))
                            {
                                File.Copy(fileslist[fa], moveRestFiles);
                            }

                            
                        }

                        for (int fe = 1550; fe < 1600 && fe < length; fe++)
                        {
                            string moveRestFiles = String.Concat(jake[11], timingTxT[fe]);
                            if (File.Exists(fileslist[fe]))
                            {
                                File.Copy(fileslist[fe], moveRestFiles);
                            }

                            
                        }

                        for (int fr = 1600; fr < 1650 && fr < length; fr++)
                        {
                            string moveRestFiles = String.Concat(jake[12], timingTxT[fr]);
                            if (File.Exists(fileslist[fr]))
                            {
                                File.Copy(fileslist[fr], moveRestFiles);
                            }

                            
                        }

                        for (int fq = 1650; fq < 1700 && fq < length; fq++)
                        {
                            string moveRestFiles = String.Concat(jake[13], timingTxT[fq]);
                            if (File.Exists(fileslist[fq]))
                            {
                                File.Copy(fileslist[fq], moveRestFiles);
                            }

                            
                        }

                        for (int fk = 1700; fk < 1750 && fk < length; fk++)
                        {
                            string moveRestFiles = String.Concat(jake[14], timingTxT[fk]);
                            if (File.Exists(fileslist[fk]))
                            {
                                File.Copy(fileslist[fk], moveRestFiles);
                            }

                            
                        }

                        for (int fj = 1750; fj < 1800 && fj < length; fj++)
                        {
                            string moveRestFiles = String.Concat(jake[15], timingTxT[fj]);
                            if (File.Exists(fileslist[fj]))
                            {
                                File.Copy(fileslist[fj], moveRestFiles);
                            }

                            
                        }

                        for (int fh = 1800; fh < 1850 && fh < length; fh++)
                        {
                            string moveRestFiles = String.Concat(jake[16], timingTxT[fh]);
                            if (File.Exists(fileslist[fh]))
                            {
                                File.Copy(fileslist[fh], moveRestFiles);
                            }

                            
                        }

                        for (int fw = 1850; fw < 1900 && fw < length; fw++)
                        {
                            string moveRestFiles = String.Concat(jake[17], timingTxT[fw]);
                            if (File.Exists(fileslist[fw]))
                            {
                                File.Copy(fileslist[fw], moveRestFiles);
                            }

                            
                        }

                        for (int fd = 1900; fd < 1950 && fd < length; fd++)
                        {
                            string moveRestFiles = String.Concat(jake[18], timingTxT[fd]);
                            if (File.Exists(fileslist[fd]))
                            {
                                File.Copy(fileslist[fd], moveRestFiles);
                            }

                            
                        }

                        for (int eu = 1950; eu < 2000 && eu < length; eu++)
                        {
                            string moveRestFiles = String.Concat(jake[19], timingTxT[eu]);
                            if (File.Exists(fileslist[eu]))
                            {
                                File.Copy(fileslist[eu], moveRestFiles);
                            }

                           
                        }




                    }
                
            }

            if (radioButton3.Checked == true)
            {
                string file = "\\Timing.txt";
                string Read = String.Concat(textBox3.Text, file);

                if (File.Exists(Read))
                    {
                        string[] timingTxT = File.ReadAllLines(Read);

                        int lengt = timingTxT.Length;

                        for (int a = 2000; a < 2050 && a < lengt; a++)
                        {
                            string moveRestFiles = String.Concat(jake[0], timingTxT[a]);
                            if (File.Exists(fileslist[a]))
                            {
                                File.Copy(fileslist[a], moveRestFiles);
                            }


                            
                        }

                        for (int b = 2050; b < 2100 && b < lengt; b++)
                        {
                            string moveRestFiles = String.Concat(jake[1], timingTxT[b]);
                            if (File.Exists(fileslist[b]))
                            {
                                File.Copy(fileslist[b], moveRestFiles);
                            }

                            
                        }

                        for (int c = 2100; c < 2150 && c < lengt; c++)
                        {
                            string moveRestFiles = String.Concat(jake[2], timingTxT[c]);
                            if (File.Exists(fileslist[c]))
                            {
                                File.Copy(fileslist[c], moveRestFiles);
                            }

                            
                        }

                        for (int d = 2150; d < 2200 && d < lengt; d++)
                        {
                            string moveRestFiles = String.Concat(jake[3], timingTxT[d]);
                            if (File.Exists(fileslist[d]))
                            {
                                File.Copy(fileslist[d], moveRestFiles);
                            }

                           
                        }

                        for (int f = 2200; f < 2250 && f < lengt; f++)
                        {
                            string moveRestFiles = String.Concat(jake[4], timingTxT[f]);
                            if (File.Exists(fileslist[f]))
                            {
                                File.Copy(fileslist[f], moveRestFiles);
                            }

                           
                        }

                        for (int aa = 2250; aa < 2300 && aa < lengt; aa++)
                        {
                            string moveRestFiles = String.Concat(jake[5], timingTxT[aa]);
                            if (File.Exists(fileslist[aa]))
                            {
                                File.Copy(fileslist[aa], moveRestFiles);
                            }

                            
                        }

                        for (int bb = 2300; bb < 2350 && bb < lengt; bb++)
                        {
                            string moveRestFiles = String.Concat(jake[6], timingTxT[bb]);
                            if (File.Exists(fileslist[bb]))
                            {
                                File.Copy(fileslist[bb], moveRestFiles);
                            }

                            
                        }

                        for (int cc = 2350; cc < 2400 && cc < lengt; cc++)
                        {
                            string moveRestFiles = String.Concat(jake[7], timingTxT[cc]);
                            if (File.Exists(fileslist[cc]))
                            {
                                File.Copy(fileslist[cc], moveRestFiles);
                            }

                            
                        }

                        for (int dd = 2400; dd < 2450 && dd < lengt; dd++)
                        {
                            string moveRestFiles = String.Concat(jake[8], timingTxT[dd]);
                            if (File.Exists(fileslist[dd]))
                            {
                                File.Copy(fileslist[dd], moveRestFiles);
                            }

                            
                        }

                        for (int ff = 2450; ff < 2500 && ff < lengt; ff++)
                        {
                            string moveRestFiles = String.Concat(jake[9], timingTxT[ff]);
                            if (File.Exists(fileslist[ff]))
                            {
                                File.Copy(fileslist[ff], moveRestFiles);
                            }

                            
                        }

                        for (int fa = 2500; fa < 2550 && fa < lengt; fa++)
                        {
                            string moveRestFiles = String.Concat(jake[10], timingTxT[fa]);
                            if (File.Exists(fileslist[fa]))
                            {
                                File.Copy(fileslist[fa], moveRestFiles);
                            }

                            
                        }

                        for (int fe = 2550; fe < 2600 && fe < lengt; fe++)
                        {
                            string moveRestFiles = String.Concat(jake[11], timingTxT[fe]);
                            if (File.Exists(fileslist[fe]))
                            {
                                File.Copy(fileslist[fe], moveRestFiles);
                            }

                            
                        }

                        for (int fr = 2600; fr < 2650 && fr < lengt; fr++)
                        {
                            string moveRestFiles = String.Concat(jake[12], timingTxT[fr]);
                            if (File.Exists(fileslist[fr]))
                            {
                                File.Copy(fileslist[fr], moveRestFiles);
                            }

                            
                        }

                        for (int fq = 2650; fq < 2700 && fq < lengt; fq++)
                        {
                            string moveRestFiles = String.Concat(jake[13], timingTxT[fq]);
                            if (File.Exists(fileslist[fq]))
                            {
                                File.Copy(fileslist[fq], moveRestFiles);
                            }

                            
                        }

                        for (int fk = 2700; fk < 2750 && fk < lengt; fk++)
                        {
                            string moveRestFiles = String.Concat(jake[14], timingTxT[fk]);
                            if (File.Exists(fileslist[fk]))
                            {
                                File.Copy(fileslist[fk], moveRestFiles);
                            }

                            
                        }

                        for (int fj = 2750; fj < 2800 && fj < lengt; fj++)
                        {
                            string moveRestFiles = String.Concat(jake[15], timingTxT[fj]);
                            if (File.Exists(fileslist[fj]))
                            {
                                File.Copy(fileslist[fj], moveRestFiles);
                            }

                           
                        }

                        for (int fh = 2800; fh < 2850 && fh < lengt; fh++)
                        {
                            string moveRestFiles = String.Concat(jake[16], timingTxT[fh]);
                            if (File.Exists(fileslist[fh]))
                            {
                                File.Copy(fileslist[fh], moveRestFiles);
                            }

                            
                        }

                        for (int fw = 2850; fw < 2900 && fw < lengt; fw++)
                        {
                            string moveRestFiles = String.Concat(jake[17], timingTxT[fw]);
                            if (File.Exists(fileslist[fw]))
                            {
                                File.Copy(fileslist[fw], moveRestFiles);
                            }

                           
                        }

                        for (int fd = 2900; fd < 2950 && fd < lengt; fd++)
                        {
                            string moveRestFiles = String.Concat(jake[18], timingTxT[fd]);
                            if (File.Exists(fileslist[fd]))
                            {
                                File.Copy(fileslist[fd], moveRestFiles);
                            }

                            
                        }

                        for (int eu = 2950; eu < 3000 && eu < lengt; eu++)
                        {
                            string moveRestFiles = String.Concat(jake[19], timingTxT[eu]);
                            if (File.Exists(fileslist[eu]))
                            {
                                File.Copy(fileslist[eu], moveRestFiles);
                            }

                            
                        }




                    }
                
            }

            if (radioButton4.Checked == true)
            {
                string file = "\\Timing.txt";
                string Read = String.Concat(textBox3.Text, file);
                    if (File.Exists(Read))
                    {
                        string[] timingTxT = File.ReadAllLines(Read);
                        int lengh = timingTxT.Length;

                        for (int a = 3000; a < 3050 && a < lengh; a++)
                        {
                            string moveRestFiles = String.Concat(jake[0], timingTxT[a]);
                            if (File.Exists(fileslist[a]))
                            {
                                File.Copy(fileslist[a], moveRestFiles);
                            }

                            
                        }

                        for (int b = 3050; b < 3100 && b < lengh; b++)
                        {
                            string moveRestFiles = String.Concat(jake[1], timingTxT[b]);
                            if (File.Exists(fileslist[b]))
                            {
                                File.Copy(fileslist[b], moveRestFiles);
                            }

                            
                        }

                        for (int c = 3100; c < 3150 && c < lengh; c++)
                        {
                            string moveRestFiles = String.Concat(jake[2], timingTxT[c]);
                            if (File.Exists(fileslist[c]))
                            {
                                File.Copy(fileslist[c], moveRestFiles);
                            }

                           
                        }

                        for (int d = 3150; d < 3200 && d < lengh; d++)
                        {
                            string moveRestFiles = String.Concat(jake[3], timingTxT[d]);
                            if (File.Exists(fileslist[d]))
                            {
                                File.Copy(fileslist[d], moveRestFiles);
                            }

                            
                        }

                        for (int f = 3200; f < 3250 && f < lengh; f++)
                        {
                            string moveRestFiles = String.Concat(jake[4], timingTxT[f]);
                            if (File.Exists(fileslist[f]))
                            {
                                File.Copy(fileslist[f], moveRestFiles);
                            }

                           
                        }

                        for (int aa = 3250; aa < 3300 && aa < lengh; aa++)
                        {
                            string moveRestFiles = String.Concat(jake[5], timingTxT[aa]);
                            if (File.Exists(fileslist[aa]))
                            {
                                File.Copy(fileslist[aa], moveRestFiles);
                            }

                            
                        }

                        for (int bb = 3300; bb < 3350 && bb < lengh; bb++)
                        {
                            string moveRestFiles = String.Concat(jake[6], timingTxT[bb]);
                            if (File.Exists(fileslist[bb]))
                            {
                                File.Copy(fileslist[bb], moveRestFiles);
                            }

                           
                        }

                        for (int cc = 3350; cc < 3400 && cc < lengh; cc++)
                        {
                            string moveRestFiles = String.Concat(jake[7], timingTxT[cc]);
                            if (File.Exists(fileslist[cc]))
                            {
                                File.Copy(fileslist[cc], moveRestFiles);
                            }

                           
                        }

                        for (int dd = 3400; dd < 3450 && dd < lengh; dd++)
                        {
                            string moveRestFiles = String.Concat(jake[8], timingTxT[dd]);
                            if (File.Exists(fileslist[dd]))
                            {
                                File.Copy(fileslist[dd], moveRestFiles);
                            }

                            
                        }

                        for (int ff = 3450; ff < 3500 && ff < lengh; ff++)
                        {
                            string moveRestFiles = String.Concat(jake[9], timingTxT[ff]);
                            if (File.Exists(fileslist[ff]))
                            {
                                File.Copy(fileslist[ff], moveRestFiles);
                            }

                           
                        }

                        for (int fa = 3500; fa < 3550 && fa < lengh; fa++)
                        {
                            string moveRestFiles = String.Concat(jake[10], timingTxT[fa]);
                            if (File.Exists(fileslist[fa]))
                            {
                                File.Copy(fileslist[fa], moveRestFiles);
                            }

                            
                        }

                        for (int fe = 3550; fe < 3600 && fe < lengh; fe++)
                        {
                            string moveRestFiles = String.Concat(jake[11], timingTxT[fe]);
                            if (File.Exists(fileslist[fe]))
                            {
                                File.Copy(fileslist[fe], moveRestFiles);
                            }

                            
                        }

                        for (int fr = 3600; fr < 3650 && fr < lengh; fr++)
                        {
                            string moveRestFiles = String.Concat(jake[12], timingTxT[fr]);
                            if (File.Exists(fileslist[fr]))
                            {
                                File.Copy(fileslist[fr], moveRestFiles);
                            }

                            
                        }

                        for (int fq = 3650; fq < 3700 && fq < lengh; fq++)
                        {
                            string moveRestFiles = String.Concat(jake[13], timingTxT[fq]);
                            if (File.Exists(fileslist[fq]))
                            {
                                File.Copy(fileslist[fq], moveRestFiles);
                            }

                           
                        }

                        for (int fk = 3700; fk < 3750 && fk < lengh; fk++)
                        {
                            string moveRestFiles = String.Concat(jake[14], timingTxT[fk]);
                            if (File.Exists(fileslist[fk]))
                            {
                                File.Copy(fileslist[fk], moveRestFiles);
                            }

                            
                        }

                        for (int fj = 3750; fj < 3800 && fj < lengh; fj++)
                        {
                            string moveRestFiles = String.Concat(jake[15], timingTxT[fj]);
                            if (File.Exists(fileslist[fj]))
                            {
                                File.Copy(fileslist[fj], moveRestFiles);
                            }

                            
                        }

                        for (int fh = 3800; fh < 3850 && fh < lengh; fh++)
                        {
                            string moveRestFiles = String.Concat(jake[16], timingTxT[fh]);
                            if (File.Exists(fileslist[fh]))
                            {
                                File.Copy(fileslist[fh], moveRestFiles);
                            }

                            
                        }

                        for (int fw = 3850; fw < 3900 && fw < lengh; fw++)
                        {
                            string moveRestFiles = String.Concat(jake[17], timingTxT[fw]);
                            if (File.Exists(fileslist[fw]))
                            {
                                File.Copy(fileslist[fw], moveRestFiles);
                            }

                            
                        }

                        for (int fd = 3900; fd < 3950 && fd < lengh; fd++)
                        {
                            string moveRestFiles = String.Concat(jake[18], timingTxT[fd]);
                            if (File.Exists(fileslist[fd]))
                            {
                                File.Copy(fileslist[fd], moveRestFiles);
                            }

                            
                        }

                        for (int eu = 3950; eu < 4000 && eu < lengh; eu++)
                        {
                            string moveRestFiles = String.Concat(jake[19], timingTxT[eu]);
                            if (File.Exists(fileslist[eu]))
                            {
                                File.Copy(fileslist[eu], moveRestFiles);
                            }
                            
                        }

                    }
                
            }

           

        }

        private void ПерейтиДляПолученияPDFФайловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://smallpdf.com/ru/jpg-to-pdf");
        }

        private void ЕдиныйТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string ie = textBox3.Text;
            DirectoryInfo dir = new DirectoryInfo(ie);
            int countu = dir.GetFiles().Length;            

            string Y3 = String.Concat(textBox3.Text, "\\01_newname.docx");

            string X3 = String.Concat(textBox3.Text, "\\02_newname.docx");

            string Z2 = String.Concat(textBox3.Text, "\\MergedFile2.docx");


            using (Document doc1 = new Document())
            {
                if (File.Exists(X3))
                {
                    doc1.LoadFromFile(Y3, FileFormat.Docx2013);
                    doc1.InsertTextFromFile(X3, FileFormat.Docx2013);
                    doc1.SaveToFile(Z2, FileFormat.Docx2013);
                }
            }
            timer1.Enabled = true;

            int Yota1 = 2;

            do
            {

                Yota1 += 1;
                string E = String.Concat(textBox3.Text, "\\0");
                string E1 = String.Concat(E, Yota1);
                string E3 = String.Concat(E1, "_newname.docx");

                
                Yota1 -= 1;
                string EZ = String.Concat(textBox3.Text, "\\MergedFile");
                string EZ1 = String.Concat(EZ, Yota1);
                string EZ2 = String.Concat(EZ1, ".docx");

                
                Yota1 += 1;
                string ZY = String.Concat(textBox3.Text, "\\MergedFile");
                string ZY1 = String.Concat(ZY, Yota1);
                string ZY2 = String.Concat(ZY1, ".docx");

                using (Document doc2 = new Document())
                {
                    if (File.Exists(E3))
                    {
                        doc2.LoadFromFile(EZ2, FileFormat.Docx2013);
                        doc2.InsertTextFromFile(E3, FileFormat.Docx2013);
                        doc2.SaveToFile(ZY2, FileFormat.Docx2013);


                    }

                    if (!File.Exists(E3))
                    {

                    }
                }
                timer1.Enabled = true;

            } while (Yota1 != countu);

            MessageBox.Show("Откройте последний документ MergedFile," + Environment.NewLine + "и пересохраните с именем (sub.txt) в кодировке другая-UTF8");

            string Ops = textBox3.Text;
            Process.Start(Ops);



        }

        private void ForeignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://forum.oszone.net/thread-205893.html");

        }

        private void MetanitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://metanit.com/sharp/windowsforms/4.19.php");
            Process.Start("https://metanit.com/sharp/windowsforms/3.5.php");
            Process.Start("https://metanit.com/sharp/windowsforms/4.16.php");
            Process.Start("https://metanit.com/sharp/windowsforms/4.5.php");
        }

        private void Приложение1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://qaru.site/questions/109314/file-count-from-a-folder");
            Process.Start("http://qaru.site/questions/1019839/how-to-add-double-quotes-to-a-string-that-is-inside-a-variable");
            Process.Start("http://www.cyberforum.ru/csharp-beginners/thread855523.html");
            Process.Start("https://remontka.pro/kak-izmenit-bukvu-diska/");
            Process.Start("https://www.youtube.com/watch?v=hJUMTOhd2B8");
            Process.Start("https://ru.stackoverflow.com/questions/993871/Освобождение-ресурсов-в-деструкторе-c");
        }

        private void Приложение2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://qaru.site/questions/109314/file-count-from-a-folder");
            Process.Start("http://qaru.site/questions/1019839/how-to-add-double-quotes-to-a-string-that-is-inside-a-variable");
            Process.Start("http://www.cyberforum.ru/csharp-beginners/thread855523.html");
            Process.Start("https://github.com/dotnet/corefx/issues/7685");
            Process.Start("https://code.msdn.microsoft.com/windowsdesktop/Merge-or-Split-Word-8f80769b");
            Process.Start("http://www.cyberforum.ru/csharp-beginners/thread266164.html");
            Process.Start("https://stackoverflow.com/questions/6481823/find-index-of-an-int-in-a-list");
        }

        private void Приложение3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cyberforum.ru/csharp-beginners/thread166977.html");
            Process.Start("http://qaru.site/questions/127275/directorygetfiles-how-to-get-only-filename-not-full-path");
            Process.Start("https://docs.microsoft.com/ru-ru/dotnet/framework/winforms/advanced/double-buffered-graphics");
            Process.Start("http://qaru.site/questions/91097/activate-tabpage-of-tabcontrol");
            Process.Start("http://qaru.site/questions/91097/activate-tabpage-of-tabcontrol");
            Process.Start("http://qaru.site/questions/54996/nuget-packages-element-is-not-declared-warning");
            Process.Start("http://ledsoft.info/articles-ru/programming-ru/csharp-ru/1-csharp-intostring-ru");
            Process.Start("https://smallpdf.com/ru/jpg-to-pdf");

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/doranimefansub?z=photo-26695890_456244893%2Falbum-26695890_175175449%2Frev");
            Process.Start("https://vk.com/doranimefansub?z=photo-26695890_396258345%2Falbum-26695890_175175449%2Frev");
            Process.Start("https://vk.com/doranimefansub?z=photo-26695890_456245266%2Falbum-26695890_175175449%2Frev");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/id28836750");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/doramsforyou?z=photo-125619425_456296769%2Falbum-125619425_0%2Frev");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/fabric_handmade");
        }

        
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Time1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void ПерейтиКПервойПапкеСКопиямиФотокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Ops = String.Concat(textBox2.Text, "\\a");
            Process.Start(Ops);
        }

       

        private void ПодучитьДокументыНеобходимыеДляРаботыСПрограммойToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string a = "\\Timing.txt";
            string b = "\\TimingAndPaths.txt";
            string c = "\\ReadMe.txt";

            string ab = String.Concat(textBox3.Text, a);
            string be = String.Concat(textBox3.Text, b);
            string ct = String.Concat(textBox3.Text, c);


            if (!File.Exists(ab))
            {
                using (File.Create(ab))
                {

                }
            }

            if (!File.Exists(be))
            {
                using (File.Create(be))
                {

                }
            }

            if (!File.Exists(ct))
            {
                using (File.Create(ct))
                {

                }
            }


        }

        private void ДокументыНаСледующуюСериюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "\\Timing.txt";
            string b = "\\TimingAndPaths.txt";
            
            string d = "\\sub.srt";
            string fe = "\\sub.txt";
            

            string ab = String.Concat(textBox3.Text, a);
            string be = String.Concat(textBox3.Text, b);
            
            string de = String.Concat(textBox3.Text, d);
            string fer = String.Concat(textBox3.Text, fe);


            if (File.Exists(ab))
            {
                File.Delete(ab);
                using (File.Create(ab))
                {

                }
            }

            if (File.Exists(be))
            {
                File.Delete(be);
                using (File.Create(be))
                {

                }
            }

            

            if (File.Exists(de))
            {
                File.Delete(de);
                
            }

            if (File.Exists(fer))
            {
                File.Delete(fer);
                
            }

            for (int i = 1, r = 81; i != r; i++)
            {
                string nn1 = textBox3.Text;
                string nn2 = "\\0";
                string nn3 = "newname.docx";
                string nn4 = String.Concat(nn1, nn2);
                string nn5 = String.Concat(nn4, i);
                string nn6 = String.Concat(nn5, nn3);

                if (File.Exists(nn6))
                {
                    File.Delete(nn6);
                }
            }

            for (int u = 2, y = 81; u != y; u++)
            {
                string nn7 = textBox3.Text;
                string nn8 = "\\MergedFile";
                string nn9 = "newname.docx";
                string nn10 = String.Concat(nn7, nn8);
                string nn11 = String.Concat(nn10, u);
                string nn12 = String.Concat(nn11, nn9);

                if (File.Exists(nn12))
                {
                    File.Delete(nn12);
                }
            }
        }
    }
}
