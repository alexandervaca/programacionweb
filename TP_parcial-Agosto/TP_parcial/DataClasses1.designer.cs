#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP_parcial
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="alumnosLQ")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertComentarios(Comentario instance);
    partial void UpdateComentarios(Comentario instance);
    partial void DeleteComentarios(Comentario instance);
    partial void InsertAlumnos(Alumno instance);
    partial void UpdateAlumnos(Alumno instance);
    partial void DeleteAlumnos(Alumno instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["alumnosLQConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Comentario> Comentarios
		{
			get
			{
				return this.GetTable<Comentario>();
			}
		}
		
		public System.Data.Linq.Table<Alumno> Alumnos
		{
			get
			{
				return this.GetTable<Alumno>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comentarios")]
	public partial class Comentario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idComentario;
		
		private int _idAlumno;
		
		private string _comentario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidComentarioChanging(int value);
    partial void OnidComentarioChanged();
    partial void OnidAlumnoChanging(int value);
    partial void OnidAlumnoChanged();
    partial void OncomentarioChanging(string value);
    partial void OncomentarioChanged();
    #endregion
		
		public Comentario()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idComentario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idComentario
		{
			get
			{
				return this._idComentario;
			}
			set
			{
				if ((this._idComentario != value))
				{
					this.OnidComentarioChanging(value);
					this.SendPropertyChanging();
					this._idComentario = value;
					this.SendPropertyChanged("idComentario");
					this.OnidComentarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAlumno", DbType="Int NOT NULL")]
		public int idAlumno
		{
			get
			{
				return this._idAlumno;
			}
			set
			{
				if ((this._idAlumno != value))
				{
					this.OnidAlumnoChanging(value);
					this.SendPropertyChanging();
					this._idAlumno = value;
					this.SendPropertyChanged("idAlumno");
					this.OnidAlumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comentario", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string comentario
		{
			get
			{
				return this._comentario;
			}
			set
			{
				if ((this._comentario != value))
				{
					this.OncomentarioChanging(value);
					this.SendPropertyChanging();
					this._comentario = value;
					this.SendPropertyChanged("comentario");
					this.OncomentarioChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Alumnos")]
	public partial class Alumno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAlumno;
		
		private string _nombre;
		
		private string _apellido;
		
		private int _dni;
		
		private string _email;
		
		private string _turno;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAlumnoChanging(int value);
    partial void OnidAlumnoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    partial void OndniChanging(int value);
    partial void OndniChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnturnoChanging(string value);
    partial void OnturnoChanged();
    #endregion
		
		public Alumno()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAlumno", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAlumno
		{
			get
			{
				return this._idAlumno;
			}
			set
			{
				if ((this._idAlumno != value))
				{
					this.OnidAlumnoChanging(value);
					this.SendPropertyChanging();
					this._idAlumno = value;
					this.SendPropertyChanged("idAlumno");
					this.OnidAlumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this.OnapellidoChanging(value);
					this.SendPropertyChanging();
					this._apellido = value;
					this.SendPropertyChanged("apellido");
					this.OnapellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dni", DbType="Int NOT NULL")]
		public int dni
		{
			get
			{
				return this._dni;
			}
			set
			{
				if ((this._dni != value))
				{
					this.OndniChanging(value);
					this.SendPropertyChanging();
					this._dni = value;
					this.SendPropertyChanged("dni");
					this.OndniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_turno", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string turno
		{
			get
			{
				return this._turno;
			}
			set
			{
				if ((this._turno != value))
				{
					this.OnturnoChanging(value);
					this.SendPropertyChanging();
					this._turno = value;
					this.SendPropertyChanged("turno");
					this.OnturnoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
