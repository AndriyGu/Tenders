﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestTenders.Models.dbdiag
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Tenders")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertTypeTender(TypeTender instance);
    partial void UpdateTypeTender(TypeTender instance);
    partial void DeleteTypeTender(TypeTender instance);
    partial void InsertCurrency(Currency instance);
    partial void UpdateCurrency(Currency instance);
    partial void DeleteCurrency(Currency instance);
    partial void InsertOrg(Org instance);
    partial void UpdateOrg(Org instance);
    partial void DeleteOrg(Org instance);
    partial void InsertTender(Tender instance);
    partial void UpdateTender(Tender instance);
    partial void DeleteTender(Tender instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::TestTenders.Properties.Settings.Default.TendersConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<TypeTender> TypeTenders
		{
			get
			{
				return this.GetTable<TypeTender>();
			}
		}
		
		public System.Data.Linq.Table<Currency> Currencies
		{
			get
			{
				return this.GetTable<Currency>();
			}
		}
		
		public System.Data.Linq.Table<Org> Orgs
		{
			get
			{
				return this.GetTable<Org>();
			}
		}
		
		public System.Data.Linq.Table<Tender> Tenders
		{
			get
			{
				return this.GetTable<Tender>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Category1;
		
		private EntitySet<Tender> _Tenders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCategory1Changing(string value);
    partial void OnCategory1Changed();
    #endregion
		
		public Category()
		{
			this._Tenders = new EntitySet<Tender>(new Action<Tender>(this.attach_Tenders), new Action<Tender>(this.detach_Tenders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Category", Storage="_Category1", DbType="NChar(250) NOT NULL", CanBeNull=false)]
		public string Category1
		{
			get
			{
				return this._Category1;
			}
			set
			{
				if ((this._Category1 != value))
				{
					this.OnCategory1Changing(value);
					this.SendPropertyChanging();
					this._Category1 = value;
					this.SendPropertyChanged("Category1");
					this.OnCategory1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Tender", Storage="_Tenders", ThisKey="Id", OtherKey="CategoryID")]
		public EntitySet<Tender> Tenders
		{
			get
			{
				return this._Tenders;
			}
			set
			{
				this._Tenders.Assign(value);
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
		
		private void attach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TypeTenders")]
	public partial class TypeTender : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private EntitySet<Tender> _Tenders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public TypeTender()
		{
			this._Tenders = new EntitySet<Tender>(new Action<Tender>(this.attach_Tenders), new Action<Tender>(this.detach_Tenders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NChar(100)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TypeTender_Tender", Storage="_Tenders", ThisKey="Id", OtherKey="TypeID")]
		public EntitySet<Tender> Tenders
		{
			get
			{
				return this._Tenders;
			}
			set
			{
				this._Tenders.Assign(value);
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
		
		private void attach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.TypeTender = this;
		}
		
		private void detach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.TypeTender = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Currency")]
	public partial class Currency : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Currency1;
		
		private EntitySet<Tender> _Tenders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCurrency1Changing(string value);
    partial void OnCurrency1Changed();
    #endregion
		
		public Currency()
		{
			this._Tenders = new EntitySet<Tender>(new Action<Tender>(this.attach_Tenders), new Action<Tender>(this.detach_Tenders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Currency", Storage="_Currency1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Currency1
		{
			get
			{
				return this._Currency1;
			}
			set
			{
				if ((this._Currency1 != value))
				{
					this.OnCurrency1Changing(value);
					this.SendPropertyChanging();
					this._Currency1 = value;
					this.SendPropertyChanged("Currency1");
					this.OnCurrency1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Tender", Storage="_Tenders", ThisKey="Id", OtherKey="CurrencyID")]
		public EntitySet<Tender> Tenders
		{
			get
			{
				return this._Tenders;
			}
			set
			{
				this._Tenders.Assign(value);
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
		
		private void attach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.Currency = this;
		}
		
		private void detach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.Currency = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Org")]
	public partial class Org : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _OrgTender;
		
		private EntitySet<Tender> _Tenders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOrgTenderChanging(string value);
    partial void OnOrgTenderChanged();
    #endregion
		
		public Org()
		{
			this._Tenders = new EntitySet<Tender>(new Action<Tender>(this.attach_Tenders), new Action<Tender>(this.detach_Tenders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgTender", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string OrgTender
		{
			get
			{
				return this._OrgTender;
			}
			set
			{
				if ((this._OrgTender != value))
				{
					this.OnOrgTenderChanging(value);
					this.SendPropertyChanging();
					this._OrgTender = value;
					this.SendPropertyChanged("OrgTender");
					this.OnOrgTenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Org_Tender", Storage="_Tenders", ThisKey="Id", OtherKey="OrgID")]
		public EntitySet<Tender> Tenders
		{
			get
			{
				return this._Tenders;
			}
			set
			{
				this._Tenders.Assign(value);
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
		
		private void attach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.Org = this;
		}
		
		private void detach_Tenders(Tender entity)
		{
			this.SendPropertyChanging();
			entity.Org = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tenders")]
	public partial class Tender : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ObjTender;
		
		private string _DeskTender;
		
		private int _OrgID;
		
		private int _TypeID;
		
		private int _CategoryID;
		
		private decimal _Budget;
		
		private int _CurrencyID;
		
		private System.DateTime _StartDate;
		
		private System.Nullable<System.DateTime> _EndDate;
		
		private System.Nullable<System.DateTime> _PubDate;
		
		private EntityRef<Category> _Category;
		
		private EntityRef<Currency> _Currency;
		
		private EntityRef<Org> _Org;
		
		private EntityRef<TypeTender> _TypeTender;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnObjTenderChanging(string value);
    partial void OnObjTenderChanged();
    partial void OnDeskTenderChanging(string value);
    partial void OnDeskTenderChanged();
    partial void OnOrgIDChanging(int value);
    partial void OnOrgIDChanged();
    partial void OnTypeIDChanging(int value);
    partial void OnTypeIDChanged();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnBudgetChanging(decimal value);
    partial void OnBudgetChanged();
    partial void OnCurrencyIDChanging(int value);
    partial void OnCurrencyIDChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEndDateChanged();
    partial void OnPubDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPubDateChanged();
    #endregion
		
		public Tender()
		{
			this._Category = default(EntityRef<Category>);
			this._Currency = default(EntityRef<Currency>);
			this._Org = default(EntityRef<Org>);
			this._TypeTender = default(EntityRef<TypeTender>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ObjTender", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string ObjTender
		{
			get
			{
				return this._ObjTender;
			}
			set
			{
				if ((this._ObjTender != value))
				{
					this.OnObjTenderChanging(value);
					this.SendPropertyChanging();
					this._ObjTender = value;
					this.SendPropertyChanged("ObjTender");
					this.OnObjTenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeskTender", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string DeskTender
		{
			get
			{
				return this._DeskTender;
			}
			set
			{
				if ((this._DeskTender != value))
				{
					this.OnDeskTenderChanging(value);
					this.SendPropertyChanging();
					this._DeskTender = value;
					this.SendPropertyChanged("DeskTender");
					this.OnDeskTenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrgID", DbType="Int NOT NULL")]
		public int OrgID
		{
			get
			{
				return this._OrgID;
			}
			set
			{
				if ((this._OrgID != value))
				{
					if (this._Org.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrgIDChanging(value);
					this.SendPropertyChanging();
					this._OrgID = value;
					this.SendPropertyChanged("OrgID");
					this.OnOrgIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeID", DbType="Int NOT NULL")]
		public int TypeID
		{
			get
			{
				return this._TypeID;
			}
			set
			{
				if ((this._TypeID != value))
				{
					if (this._TypeTender.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._TypeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL")]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Budget", DbType="Decimal(18,4) NOT NULL")]
		public decimal Budget
		{
			get
			{
				return this._Budget;
			}
			set
			{
				if ((this._Budget != value))
				{
					this.OnBudgetChanging(value);
					this.SendPropertyChanging();
					this._Budget = value;
					this.SendPropertyChanged("Budget");
					this.OnBudgetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrencyID", DbType="Int NOT NULL")]
		public int CurrencyID
		{
			get
			{
				return this._CurrencyID;
			}
			set
			{
				if ((this._CurrencyID != value))
				{
					if (this._Currency.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCurrencyIDChanging(value);
					this.SendPropertyChanging();
					this._CurrencyID = value;
					this.SendPropertyChanged("CurrencyID");
					this.OnCurrencyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PubDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> PubDate
		{
			get
			{
				return this._PubDate;
			}
			set
			{
				if ((this._PubDate != value))
				{
					this.OnPubDateChanging(value);
					this.SendPropertyChanging();
					this._PubDate = value;
					this.SendPropertyChanged("PubDate");
					this.OnPubDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Tender", Storage="_Category", ThisKey="CategoryID", OtherKey="Id", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Tenders.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Tenders.Add(this);
						this._CategoryID = value.Id;
					}
					else
					{
						this._CategoryID = default(int);
					}
					this.SendPropertyChanged("Category");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currency_Tender", Storage="_Currency", ThisKey="CurrencyID", OtherKey="Id", IsForeignKey=true)]
		public Currency Currency
		{
			get
			{
				return this._Currency.Entity;
			}
			set
			{
				Currency previousValue = this._Currency.Entity;
				if (((previousValue != value) 
							|| (this._Currency.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Currency.Entity = null;
						previousValue.Tenders.Remove(this);
					}
					this._Currency.Entity = value;
					if ((value != null))
					{
						value.Tenders.Add(this);
						this._CurrencyID = value.Id;
					}
					else
					{
						this._CurrencyID = default(int);
					}
					this.SendPropertyChanged("Currency");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Org_Tender", Storage="_Org", ThisKey="OrgID", OtherKey="Id", IsForeignKey=true)]
		public Org Org
		{
			get
			{
				return this._Org.Entity;
			}
			set
			{
				Org previousValue = this._Org.Entity;
				if (((previousValue != value) 
							|| (this._Org.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Org.Entity = null;
						previousValue.Tenders.Remove(this);
					}
					this._Org.Entity = value;
					if ((value != null))
					{
						value.Tenders.Add(this);
						this._OrgID = value.Id;
					}
					else
					{
						this._OrgID = default(int);
					}
					this.SendPropertyChanged("Org");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TypeTender_Tender", Storage="_TypeTender", ThisKey="TypeID", OtherKey="Id", IsForeignKey=true)]
		public TypeTender TypeTender
		{
			get
			{
				return this._TypeTender.Entity;
			}
			set
			{
				TypeTender previousValue = this._TypeTender.Entity;
				if (((previousValue != value) 
							|| (this._TypeTender.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TypeTender.Entity = null;
						previousValue.Tenders.Remove(this);
					}
					this._TypeTender.Entity = value;
					if ((value != null))
					{
						value.Tenders.Add(this);
						this._TypeID = value.Id;
					}
					else
					{
						this._TypeID = default(int);
					}
					this.SendPropertyChanged("TypeTender");
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
