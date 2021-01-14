﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjektWPF.Zawody;
using ProjektWPF.Wyniki;
using ProjektWPF.Zawodnicy;
using ProjektWPF.Rozgrywki;
using ProjektWPF.Druzyny;
using ProjektWPF.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System;

namespace ProjektWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Collection<Zawodnik> Zawodnicy { get; } = new ObservableCollection<Zawodnik>();
        public Collection<Rozgrywka> Rozgrywki { get; } = new ObservableCollection<Rozgrywka>();
        public Collection<Druzyna> Druzyny { get; } = new ObservableCollection<Druzyna>();
        public Collection<Wynik> Wyniki { get; } = new ObservableCollection<Wynik>();
        ZawodnikDbContext context;

        public MainWindow(ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
            GetZawodnicy();
            GetRozgrywki();
            GetDruzyny();
            GetWyniki();
            ViewZaw.Filter = null;
            ViewRoz.Filter = null;
            ViewDruz.Filter = null;
            ViewWyn.Filter = null;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var binding = new Binding();
            ZawodnicyList.ItemsSource = Zawodnicy;
            RozgrywkiList.ItemsSource = Rozgrywki;
            lista_druzyn.ItemsSource = Druzyny;
            WynikiList.ItemsSource = Wyniki;

        }

        private ListCollectionView ViewZaw
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(Zawodnicy);
            }
        }

        private ListCollectionView ViewRoz
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(Rozgrywki);
            }
        }

        private ListCollectionView ViewDruz
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(Druzyny);
            }
        }
        private ListCollectionView ViewWyn
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(Wyniki);
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Drabinka d = new Drabinka();
            d.ShowDialog();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddZawody add = new AddZawody();

            add.Show();
        }

        private void AddWynik(object sender, RoutedEventArgs e)
        {
            AddWyniki add = new AddWyniki(context);
            if (add.ShowDialog() == true)
            {

            }
            GetWyniki();
            GetRozgrywki();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddZawody add = new AddZawody();
            add.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DeleteZawody add = new DeleteZawody();
            add.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FiltrZawody add = new FiltrZawody();
            add.Show();
        }

        private void FilterWyniki(object sender, RoutedEventArgs e)
        {
            FiltrWyniki filtr = new FiltrWyniki(ViewWyn, context);
            if (filtr.ShowDialog() == true)
            {

            }
            GetWyniki();
        }

        private void DelWyniki(object sender, RoutedEventArgs e)
        {
            DeleteWyniki del = new DeleteWyniki(context);
            del.Id = ((Wynik)WynikiList.SelectedItem).Id;

            if (del.ShowDialog() == true)
            {

            }
            GetWyniki();
            GetRozgrywki();
        }

        private void TeamWyniki(object sender, RoutedEventArgs e)
        {
            TeamWyniki add = new TeamWyniki(((Wynik)WynikiList.SelectedItem), context);
            add.Show();
            GetWyniki();
        }

        private void DetailsWyniki(object sender, RoutedEventArgs e)
        {
            DetailsWyniki add = new DetailsWyniki((Wynik)WynikiList.SelectedItem, context);
            if (add.ShowDialog() == true)
            {

            }
            GetWyniki();
        }


        private void GetZawodnicy()
        {

            var Zawodnicydb = context.Zawodnicy.ToList();
            Zawodnicy.Clear();
            foreach (Zawodnik x in Zawodnicydb)
            {
                Zawodnicy.Add(x);

            }


        }
        private void AddZawodnik(object sender, RoutedEventArgs e)
        {
            AddZawodnik add = new AddZawodnik(context);
            if (add.ShowDialog() == true)
            {

            }
            GetZawodnicy();
        }

        private void DetailsZawodnik(object sender, RoutedEventArgs e)
        {
            DetailsZawodnik det = new DetailsZawodnik(((Zawodnik)ZawodnicyList.SelectedItem));
            if (det.ShowDialog() == true)
            {

            }
            GetZawodnicy();
        }

        private void DelZawodnik(object sender, RoutedEventArgs e)
        {
            //   var productToDelete = (sender as FrameworkElement).DataContext as Zawodnik;



            DeleteZawodnik del = new DeleteZawodnik(context);
            del.Id = ((Zawodnik)ZawodnicyList.SelectedItem).Id;

            if (del.ShowDialog() == true)
            {

            }
            GetZawodnicy();
        }

        private void EditZawodnik(object sender, RoutedEventArgs e)
        {

            EditZawodnik edit = new EditZawodnik(context, ((Zawodnik)ZawodnicyList.SelectedItem));

            if (edit.ShowDialog() == true)
            {

            }

            GetZawodnicy();
        }

        private void FilterZawodnik(object sender, RoutedEventArgs e)
        {
            FilterZawodnik filtr = new FilterZawodnik(ViewZaw, context);
            if (filtr.ShowDialog() == true)
            {

            }
            GetZawodnicy();
        }

        private void UnFilterZawodnik(object sender, RoutedEventArgs e)
        {
            ViewZaw.Filter = null;
        }




        private void SortZawNone(object sender, RoutedEventArgs e)
        {
            ViewZaw.SortDescriptions.Clear();
            ViewZaw.CustomSort = null;
        }
        private void SortZawName(object sender, RoutedEventArgs e)
        {
            ViewZaw.SortDescriptions.Clear();
            ViewZaw.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }
        private void SortZawSurname(object sender, RoutedEventArgs e)
        {
            ViewZaw.SortDescriptions.Clear();
            ViewZaw.SortDescriptions.Add(new SortDescription("Surname", ListSortDirection.Ascending));
        }
        private void SortZawNumber(object sender, RoutedEventArgs e)
        {
            ViewZaw.SortDescriptions.Clear();
            ViewZaw.SortDescriptions.Add(new SortDescription("Number", ListSortDirection.Ascending));
        }

        private void GroupZawNone(object sender, RoutedEventArgs e)
        {
            ViewZaw.GroupDescriptions.Clear();
        }
        private void GroupZawPosition(object sender, RoutedEventArgs e)
        {
            ViewZaw.GroupDescriptions.Clear();
            ViewZaw.GroupDescriptions.Add(new PropertyGroupDescription("Position"));
        }

        private void GroupZawAge(object sender, RoutedEventArgs e)
        {
            ViewZaw.GroupDescriptions.Clear();
            ViewZaw.GroupDescriptions.Add(new PropertyGroupDescription("Age"));
        }
        private void GroupZawNumber(object sender, RoutedEventArgs e)
        {
            ViewZaw.GroupDescriptions.Clear();
            ViewZaw.GroupDescriptions.Add(new PropertyGroupDescription("Number"));
        }

        private void SzukajZawChange(object sender, RoutedEventArgs e)
        {
            ViewZaw.Filter = delegate (object item)
            {
                Zawodnik searchzaw = item as Zawodnik;
                if (searchzaw == null || searchzaw.Name == null || searchzaw.Surname == null)
                {
                    return false;
                }
                if (!(searchzaw.Name.Contains(SzukajZawodnik.Text)) && !(searchzaw.Surname.Contains(SzukajZawodnik.Text)) && !((searchzaw.Name + " " + searchzaw.Surname).Contains(SzukajZawodnik.Text)) && !((searchzaw.Surname + " " + searchzaw.Name).Contains(SzukajZawodnik.Text)) && !((searchzaw.Name + searchzaw.Surname).Contains(SzukajZawodnik.Text)))
                {
                    return false;
                }


                return true;
            };

        }

        private void SzukajZaw(object sender, RoutedEventArgs e)
        {
            ViewZaw.Filter = null;
            SzukajZawodnik.Text = "";
            ViewZaw.Filter = null;
        }

        private void SzukajZawReset(object sender, RoutedEventArgs e)
        {
            ViewZaw.Filter = null;
            SzukajZawodnik.Text = "Szukaj...";
            ViewZaw.Filter = null;
        }



        public void GetRozgrywki()
        {
            var Rozgrywkidb = context.Rozgrywki.ToList();
            Rozgrywki.Clear();
            foreach (Rozgrywka x in Rozgrywkidb)
            {
                if (x.WynikId==null)
                    Rozgrywki.Add(x);
            }
            ManytoManyCantBindreset();
        }
        private void DeatailsRozgrywka(object sender, RoutedEventArgs e)
        {
            DetailsRozgrywka detroz = new DetailsRozgrywka(((Rozgrywka)RozgrywkiList.SelectedItem), context);
            if (detroz.ShowDialog() == true)
            {

            }
            GetRozgrywki();
        }

        private void AddRozgrywka(object sender, RoutedEventArgs e)
        {


            AddRozgrywka addroz = new AddRozgrywka(context);
            if (addroz.ShowDialog() == true)
            {

            }
            GetRozgrywki();
        }

        private void EditRozgrywka(object sender, RoutedEventArgs e)
        {
            EditRozgrywka editroz = new EditRozgrywka(context, ((Rozgrywka)RozgrywkiList.SelectedItem));

            if (editroz.ShowDialog() == true)
            {

            }

            GetRozgrywki();

        }

        private void DelRozgrywka(object sender, RoutedEventArgs e)
        {

            //   var productToDelete = (sender as FrameworkElement).DataContext as Zawodnik;
            DeleteRozgrywka delroz = new DeleteRozgrywka(context);
            delroz.Id = ((Rozgrywka)RozgrywkiList.SelectedItem).Id;

            if (delroz.ShowDialog() == true)
            {

            }
            GetRozgrywki();
        }


        private void UnFilterRozgrywka(object sender, RoutedEventArgs e)
        {
            ViewRoz.Filter = null;
        }
        private void FilterRozgrywka(object sender, RoutedEventArgs e)
        {
            FilterRozgrywka filtrroz = new FilterRozgrywka(ViewRoz, context);
            if (filtrroz.ShowDialog() == true)
            {

            }
            GetRozgrywki();
        }


        private void SortRozNone(object sender, RoutedEventArgs e)
        {
            ViewRoz.SortDescriptions.Clear();
            ViewRoz.CustomSort = null;
        }
        private void SortRozDate(object sender, RoutedEventArgs e)
        {
            ViewRoz.SortDescriptions.Clear();
            ViewRoz.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Ascending));
        }
        private void SortRozPlace(object sender, RoutedEventArgs e)
        {
            ViewRoz.SortDescriptions.Clear();
            ViewRoz.SortDescriptions.Add(new SortDescription("Place", ListSortDirection.Ascending));
        }


        private void SzukajRozChange(object sender, RoutedEventArgs e)
        {
            ViewRoz.Filter = delegate (object item)
            {
                Rozgrywka searchroz = item as Rozgrywka;
                if (searchroz == null)
                {
                    return false;
                }
                if (searchroz.Place == null)
                {
                    return false;
                }
                if (!(searchroz.Place.Contains(SzukajRozgrywka.Text)) && !(searchroz.Date.ToString().Substring(0, searchroz.Date.ToString().Length - 9).Contains(SzukajRozgrywka.Text)) && !((searchroz.Date.ToString().Substring(0, searchroz.Date.ToString().Length - 9) + " " + searchroz.Place).Contains(SzukajRozgrywka.Text)) && !((searchroz.Place + " " + searchroz.Date.ToString().Substring(0, searchroz.Date.ToString().Length - 9)).Contains(SzukajRozgrywka.Text)))
                {

                    return false;
                }


                return true;
            };

        }
        private void SzukajWynChange(object sender, RoutedEventArgs e)
        {
            ViewWyn.Filter = delegate (object item)
            {
                Wynik searchwyn = item as Wynik;
                if (searchwyn == null)
                {
                    return false;
                }
                var pom = context.Rozgrywki.First(e => e.Id == searchwyn.RozgrywkaId);

                if (pom.Place == null)
                {
                    return false;
                }
                //if(!pom.Place.Contains(Szukaj)
                if (!(pom.Place.Contains(SzukajWynik.Text)) && !(pom.Date.ToString().Substring(0, pom.Date.ToString().Length - 13).Contains(SzukajWynik.Text)) && !((pom.Date.ToString().Substring(0, pom.Date.ToString().Length - 13) + " " + pom.Place).Contains(SzukajWynik.Text)) && !((pom.Place + " " + pom.Date.ToString().Substring(0, pom.Date.ToString().Length - 13)).Contains(SzukajWynik.Text)))
                {

                    return false;
                }


                return true;
            };

        }

        private void SzukajRoz(object sender, RoutedEventArgs e)
        {
            ViewRoz.Filter = null;
            SzukajRozgrywka.Text = "";
            ViewRoz.Filter = null;
        }
        private void SzukajWyn(object sender, RoutedEventArgs e)
        {
            ViewWyn.Filter = null;
            SzukajWynik.Text = "";
            ViewWyn.Filter = null;
        }

        private void SzukajRozReset(object sender, RoutedEventArgs e)
        {
            ViewRoz.Filter = null;
            SzukajRozgrywka.Text = "Szukaj...";
            ViewRoz.Filter = null;
        }
        private void SzukajWynReset(object sender, RoutedEventArgs e)
        {
            ViewWyn.Filter = null;
            SzukajWynik.Text = "Szukaj...";
            ViewWyn.Filter = null;
        }



        private void DrużynyRozgrywka(object sender, RoutedEventArgs e)
        {
            DrużynyRozgrywka druroz = new DrużynyRozgrywka(((Rozgrywka)RozgrywkiList.SelectedItem), context);
            druroz.Show();
            GetRozgrywki();
        }

        public void GetDruzyny()
        {
            var Druzynydb = context.Druzyny.ToList();
            Druzyny.Clear();
            foreach (Druzyna x in Druzynydb)
            {
                Druzyny.Add(x);
            }
        }
        public void GetWyniki()
        {
            var Wynikidb = context.Wyniki.ToList();
            Wyniki.Clear();
            foreach (Wynik x in Wynikidb)
            {
                Wyniki.Add(x);
            }
        }

        private void DodajDruzyne(object sender, RoutedEventArgs e)
        {
            AddDruzyna druzynadodaj = new AddDruzyna(context);
            if (druzynadodaj.ShowDialog() == true)
            {

            }
            GetDruzyny();
        }

        private void DodajZawodnikaDoDruzyny(object sender, RoutedEventArgs e)
        {
            AddZawodnikDoDruzyny addZawodnikDoDruzyny = new AddZawodnikDoDruzyny(context, ((Druzyna)lista_druzyn.SelectedItem), Zawodnicy);
            if (addZawodnikDoDruzyny.ShowDialog() == true)
            {

            }
            GetDruzyny();
        }
        private void UsunZawodnikaZDruzyny(object sender, RoutedEventArgs e)
        {
            DeleteZawodnikZDruzyny deleteZawodnikZDruzyny = new DeleteZawodnikZDruzyny(context, ((Druzyna)lista_druzyn.SelectedItem), Zawodnicy);
            GetZawodnicy();
            if (deleteZawodnikZDruzyny.ShowDialog() == true)
            {

            }
            GetDruzyny();
        }

        private void FiltrujDruzyne(object sender, RoutedEventArgs e)
        {
            FilterDruzyna filterDruzyna = new FilterDruzyna(ViewDruz);
            if (filterDruzyna.ShowDialog() == true)
            {

            }
            GetDruzyny();
        }

        private void UsunFilterDruzyna(object sender, RoutedEventArgs e)
        {
            ViewDruz.Filter = null;
        }

        private void UsunDruzyne(object sender, RoutedEventArgs e)
        {
            DeleteDruzyna deleteDruzyna = new DeleteDruzyna(context);
            deleteDruzyna.Id = ((Druzyna)lista_druzyn.SelectedItem).Id;
            if (deleteDruzyna.ShowDialog() == true)
            {

            }
            GetDruzyny();
        }

        private void EdytujDruzyne(object sender, RoutedEventArgs e)
        {
            EditDruzyny editDruzyny = new EditDruzyny(context, ((Druzyna)lista_druzyn.SelectedItem));
            if (editDruzyny.ShowDialog() == true)
            {

            }
            GetDruzyny();
        }

        private void SzukajDruzynyChange(object sender, RoutedEventArgs e)
        {
            ViewDruz.Filter = delegate (object item)
            {
                Druzyna searchdruz = item as Druzyna;
                if (searchdruz == null || searchdruz.Nazwa == null)
                {
                    return false;
                }
                if (!(searchdruz.Nazwa.Contains(Szukaj_druzyny.Text)))
                {
                    return false;
                }
                return true;
            };

        }

        private void SzukajDruzyny(object sender, RoutedEventArgs e)
        {
            ViewDruz.Filter = null;
            Szukaj_druzyny.Text = "";
            ViewDruz.Filter = null;
        }

        private void SzukajDruzynyReset(object sender, RoutedEventArgs e)
        {
            ViewDruz.Filter = null;
            Szukaj_druzyny.Text = "Szukaj...";
            ViewDruz.Filter = null;
        }

        private void ManytoManyCantBind(object sender, SelectionChangedEventArgs e)
        {
            Rozgrywka roz = (Rozgrywka)RozgrywkiList.SelectedItem;
            if (roz != null)
            {
                var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == roz.Id).ToList();
                if (pom.Count > 1)
                {
                    Team1.Content = pom[0].Druzyna.Nazwa;
                    Team2.Content = pom[1].Druzyna.Nazwa;
                    Image1.Source = new BitmapImage(new Uri(pom[0].Druzyna.ImagePath));
                    Image2.Source = new BitmapImage(new Uri(pom[1].Druzyna.ImagePath));
                }
                else if (pom.Count == 1)
                {
                    Team1.Content = pom[0].Druzyna.Nazwa;
                    Team2.Content = "";
                    Image1.Source = new BitmapImage(new Uri(pom[0].Druzyna.ImagePath));
                    Image2.Source = null;

                }
                else
                {
                    Team1.Content = "";
                    Team2.Content = "";
                    Image1.Source = null;
                    Image2.Source = null;
                }
            }
        }
        private void ManytoManyCantBind2(object sender, SelectionChangedEventArgs e)
        {
            if ((Wynik)WynikiList.SelectedItem != null)
            {
                Rozgrywka roz = context.Rozgrywki.First(e => e.Id == ((Wynik)WynikiList.SelectedItem).RozgrywkaId);
                if (roz != null)
                {
                    var pom = context.Druzyna_Rozgrywka.Where(z => z.RozgrywkaId == roz.Id).ToList();
                    if (pom.Count > 1)
                    {
                        Dru1.Content = pom[0].Druzyna.Nazwa;
                        Dru2.Content = pom[1].Druzyna.Nazwa;
                        Image11.Source = new BitmapImage(new Uri(pom[0].Druzyna.ImagePath));
                        Image22.Source = new BitmapImage(new Uri(pom[1].Druzyna.ImagePath));
                    }
                    else if (pom.Count == 1)
                    {
                        Dru1.Content = pom[0].Druzyna.Nazwa;
                        Dru2.Content = "";
                        Image11.Source = new BitmapImage(new Uri(pom[0].Druzyna.ImagePath));
                        Image22.Source = null;

                    }
                    else
                    {
                        Dru1.Content = "";
                        Dru2.Content = "";
                        Image11.Source = null;
                        Image22.Source = null;
                    }
                    Miejscóweczka.Content = roz.Place;
                }
            }
        }
        private void ManytoManyCantBindreset()
        {
            


            Team1.Content = "";
                Team2.Content = "";
                Image1.Source = null;
                Image2.Source = null;
            
        }
    }
}
