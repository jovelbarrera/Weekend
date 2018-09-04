using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Services;
//using Weekend.i18n;
using Weekend.Models;
//using Weekend.Services;
using Xamarin.Forms;

namespace Weekend.ViewModels
{
	public class TripsPageViewModel : ViewModelBase
	{
		private IPageDialogService _dialogService;
		private ObservableCollection<Trip> _trips;
		public ObservableCollection<Trip> Trips
		{
			get { return _trips; }
			set { SetProperty(ref _trips, value); }
		}

		public Command ItemTappedCommand { get; set; }

		public TripsPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
			: base(navigationService)
		{
			Title = "Home";
			//Title = AppResources.Restaurants;
			Trips = new ObservableCollection<Trip>();
			ItemTappedCommand = new Command(async (e) => await OpenDetail(e));
			_dialogService = dialogService;
			LoadData().ConfigureAwait(false);
		}

		public async Task OpenDetail(object e)
		{
			NavigationParameters parameters = new NavigationParameters();
			parameters.Add("trip", e as Trip);
			await MainPageViewModel.NavigationService.NavigateAsync("TripDetailPage", parameters);
		}

		public override void OnNavigatingTo(NavigationParameters parameters)
		{
			base.OnNavigatingTo(parameters);
		}

		public override void OnNavigatedFrom(NavigationParameters parameters)
		{
			base.OnNavigatedFrom(parameters);
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);
		}

		private async Task LoadData()
		{
			if (Trips?.Count > 0)
				return;
			try
			{
				Trips.Add(new Trip
				{
					Id = "",
					Icon = "",
					Name = "Ruta de las flores",
					Picture = "http://infoguiaelsalvador.com/wp-content/uploads/2016/11/infoguia-el-salvador-ruta-de-las-flores-nahuizalco-700x525.jpg",
					Tickets = 2,
					Price = 25,
					Date = DateTime.Today.AddDays(1),
					Description = @"Vamos a la famosa RUTA DE LAS FLORES este DOMINGO 20 DE MAYO a un PRECIO DE LOCURA 2 PERSONAS POR $25 y acompáñanos a conocer EL LABERINTO DE ALBANIA Y LOS CHORROS DE LA CALERA, ademas de MUCHOS ATRACTIVOS MAS.
➡Día: Domingo 20 de Mayo
➡Lugar de Salida: Gasolinera Puma los Heroes a un costado del Ex Mundo Feliz 
➡Hora de Salida: 6:30am
➡Hora de llegada a Punto de salida: 6:00pm

Visitaremos:
☑️Desayuno en Ataco
☑️Caminata al Mirador de La Cruz(Ataco) 
☑️visita al pueblo y Mercado de Artesanías de Ataco
☑️Aventura en el Laberinto de Albania(Apaneca)
☑️Aventura en Los Chorros de La Calera(Juayua)
☑️Visita a plaza gastronómica a comer yuca(Salcoatitan)

➡Costo: 2 personas por $25 - (Niños Menores de 3 años en piernas viajan gratis)

Incluye:
☑️Trasporte de lujo, Techo Alto, Full Aire Acondicionado y con Asientos de Butaca para su mayor comodidad.
☑️Guía Turístico 
☑️Coordinador de Grupo
☑️Botella con agua
☑️Diversión y Entretenimiento al Máximo
☑️Botiquín de Primeros Auxilios.

No incluye: 
☑️Alimentación
☑️Entrada Laberinto Albania $3.00
☑️Pago Moto-taxi hacia los Chorros de la Calera $2.00

Recomendaciones:
➡ Ropa y zapatos cómodos y confortables.👟👡
➡ Llevar Celular o Camara para tomar muchas fotos 📸
➡ Llevar traje de baño para los que quieran bañarse en los Chorros de la Calera. 🏊‍♂️🏊‍♀️

Métodos de pago:
✅ Deposito a Cuenta Bancaria Agrícola
✅ Personal(Centros comerciales San Salvador)

IMPORTANTE
➡ Depositar el 50 % del costo del viaje a los métodos mencionados a mas tardar 1 días antes de la realización del viaje(18 de mayo)
➡️El numero mínimo de Turistas para poder realizar el viaje es de 10 personas.
➡ Si por cualquier motivo de fuerza mayor se cancela el viaje se depositara en su totalidad el dinero a cada uno de nuestros viajeros. 
➡La Empresa no se hace responsable por objetos extraviados o olvidados en alguno de los lugares que visitemos."
				});
				Trips.Add(new Trip
				{
					Id = "",
					Icon = "",
					Name = "Finca de los girasoles y Basílica de Esquipulas - Guatemala",
					Picture = "https://www.guatemala.com/fotos/201707/Basilica-de-Esquipulas-885x500.jpg",
					Tickets = 1,
					Price = 15,
					Date = DateTime.Today.AddDays(1),
					Description = @"➡Día: Domingo 20 de Mayo
➡Lugar de Salida: Gasolinera Puma Los Héroes, a un costado del Ex Mundo Feliz 
➡Hora de Salida: 5:30am
➡Hora de llegada a Punto de salida: 7:00pm

Visitaremos:
☑️Basílica del Cristo Negro
☑️Visita a Finca Productora de Girasoles
☑️Entre otros atractivos del lugar.

➡Costo: $15 por Persona, (Niños Menores de 3 años en piernas viajan gratis)

Incluye:
☑️Trasporte de lujo, Techo Alto, Full Aire Acondicionado y con Asientos de Butaca para su mayor comodidad.
☑️Guía Turístico 
☑️Coordinador de Grupo
☑️Botella con Agua
☑️Diversión y Entretenimiento al Máximo
☑️Botiquín de Primeros Auxilios.

No incluye: 
☑️Alimentación 
☑️Entrada a Finca de los girasoles

Recomendaciones: 
➡ Ropa y zapatos cómodos.👟👡
➡ Llevar alimentos para ir comiendo durante el camino.
➡ Llevar Celular o Camara para tomar muchas fotos 📸
➡ Llevar mucha agua para estar hidratados 🥤
➡️Adultos con DUI o Pasaporte vigente.
➡ Menores de edad con pasaporte vigente.
➡Niños sin un padre de familia presentar permiso por un notario modificado con la ley LEPINA. (Original y 2 copias)

Métodos de pago:
✅ Cuenta Bancaria Agricola 
✅ Tigo Money
✅ Personal en centros comerciales San Salvador
✅ Personal hasta su lugar de trabajo sin recargo adicional

IMPORTANTE 
➡ Depositar el 50% del costo del viaje a los métodos mencionados a mas tardar 1 días antes de la realización del viaje (19 de Mayo)
➡️El numero mínimo de Turistas para garantizar el viaje es de 10 personas.
➡ Si por cualquier motivo de fuerza mayor se cancela el viaje se depositara en su totalidad el dinero a cada uno de nuestros viajeros. 
➡La Empresa no se hace responsable por objetos extraviados o olvidados en alguno de los lugares que visitemos.",
				});

				Trips.Add(new Trip
				{
					Id = "",
					Icon = "",
					Name = "Ruta de la Paz - Morazán",
					Picture = "http://2.bp.blogspot.com/-0LqCoyAACBw/UaYDbA6q7lI/AAAAAAAAAAs/y5vrzKUmGpA/s1600/Ruta+la+paz.jpg",
					Tickets = 1,
					Price = 25,
					Date = DateTime.Today.AddDays(1),
					Description = @"Quieres tener una magnifica AVENTURA con la Historia en la RUTA DE LA PAZ en MORAZAN pues acompáñanos a este maravilloso destino, visitando Cascada el Chorreron, Rio Sapo, Museo de la Revolución, El Mozote y LLano del Muerto.

➡Día: Domingo 20 de Mayo
➡Lugar de Salida: Gasolinera PUMA los Héroes a un costado del Ex Mundo Feliz.
➡Hora de Salida: 4:00am
➡Hora de llegada a Punto de salida: 8:00pm

➡Costo: $25 por Persona, (Niños Menores de 3 años en piernas viajan gratis)

Visitaremos:
☑️Museo de la Revolución
☑️Cascada el Chorreron
☑️Rio Sapo
☑️El Mozote
☑️Llano del Muerto

Incluye:
☑️Trasporte de lujo, Techo Alto, Full Aire Acondicionado y con Asientos de Butaca para su mayor comodidad.
☑️Guía Turístico 
☑️Coordinador de Grupo
☑️Botella con Agua
☑️Diversión y Entretenimiento al Máximo
☑️Botiquín de Primeros Auxilios.

No incluye: 
☑️Alimentación 
☑️Entrada al Museo de la Revolucion

Recomendaciones: 
➡ Ropa y zapatos cómodos.👟👡
➡ Llevar Celular o Camara para tomar muchas fotos 📸
➡ Llevar mucha agua para estar hidratados 🥤

Métodos de pago:
✅ Cuenta Bancaria Agrícola 
✅ Personal en centros comerciales San Salvador
✅ Personal hasta su lugar de trabajo sin un recargo adicional

IMPORTANTE 
➡ Depositar el 50% del costo del viaje a los métodos mencionados a mas tardar 2 días antes de la realización del viaje: 18 de mayo)
➡️El numero mínimo de Turistas para garantizar el viaje es de 10 personas.
➡ Si por cualquier motivo de fuerza mayor se cancela el viaje se depositara en su totalidad el dinero a cada uno de nuestros viajeros. 
➡La Empresa no se hace responsable por objetos extraviados o olvidados en alguno de los lugares que visitemos.",
				});
			}
			catch (Exception ex)
			{
				var a = ex.Message;
			}
		}
	}
}