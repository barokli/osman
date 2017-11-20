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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="osman")]
public partial class SoruDBDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertdt_answerOS(dt_answerOS instance);
  partial void Updatedt_answerOS(dt_answerOS instance);
  partial void Deletedt_answerOS(dt_answerOS instance);
  partial void Insertdt_membershipOS(dt_membershipOS instance);
  partial void Updatedt_membershipOS(dt_membershipOS instance);
  partial void Deletedt_membershipOS(dt_membershipOS instance);
  partial void Insertdt_questionOS(dt_questionOS instance);
  partial void Updatedt_questionOS(dt_questionOS instance);
  partial void Deletedt_questionOS(dt_questionOS instance);
  partial void Insertlu_lessonOS(lu_lessonOS instance);
  partial void Updatelu_lessonOS(lu_lessonOS instance);
  partial void Deletelu_lessonOS(lu_lessonOS instance);
  partial void Insertlu_topicOS(lu_topicOS instance);
  partial void Updatelu_topicOS(lu_topicOS instance);
  partial void Deletelu_topicOS(lu_topicOS instance);
  partial void Inserttx_answeredQuestionOS(tx_answeredQuestionOS instance);
  partial void Updatetx_answeredQuestionOS(tx_answeredQuestionOS instance);
  partial void Deletetx_answeredQuestionOS(tx_answeredQuestionOS instance);
  partial void Insertdt_memberTopicOS(dt_memberTopicOS instance);
  partial void Updatedt_memberTopicOS(dt_memberTopicOS instance);
  partial void Deletedt_memberTopicOS(dt_memberTopicOS instance);
  #endregion
	
	public SoruDBDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["osmanConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public SoruDBDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SoruDBDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SoruDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SoruDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<dt_answerOS> dt_answerOS
	{
		get
		{
			return this.GetTable<dt_answerOS>();
		}
	}
	
	public System.Data.Linq.Table<dt_membershipOS> dt_membershipOS
	{
		get
		{
			return this.GetTable<dt_membershipOS>();
		}
	}
	
	public System.Data.Linq.Table<dt_questionOS> dt_questionOS
	{
		get
		{
			return this.GetTable<dt_questionOS>();
		}
	}
	
	public System.Data.Linq.Table<lu_lessonOS> lu_lessonOS
	{
		get
		{
			return this.GetTable<lu_lessonOS>();
		}
	}
	
	public System.Data.Linq.Table<lu_topicOS> lu_topicOS
	{
		get
		{
			return this.GetTable<lu_topicOS>();
		}
	}
	
	public System.Data.Linq.Table<tx_answeredQuestionOS> tx_answeredQuestionOS
	{
		get
		{
			return this.GetTable<tx_answeredQuestionOS>();
		}
	}
	
	public System.Data.Linq.Table<dt_memberTopicOS> dt_memberTopicOS
	{
		get
		{
			return this.GetTable<dt_memberTopicOS>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dt_answers")]
public partial class dt_answerOS : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _answer;
	
	private int _question_id;
	
	private EntityRef<dt_questionOS> _dt_questionOS;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnanswerChanging(string value);
    partial void OnanswerChanged();
    partial void Onquestion_idChanging(int value);
    partial void Onquestion_idChanged();
    #endregion
	
	public dt_answerOS()
	{
		this._dt_questionOS = default(EntityRef<dt_questionOS>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
	public string answer
	{
		get
		{
			return this._answer;
		}
		set
		{
			if ((this._answer != value))
			{
				this.OnanswerChanging(value);
				this.SendPropertyChanging();
				this._answer = value;
				this.SendPropertyChanged("answer");
				this.OnanswerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_question_id", DbType="Int NOT NULL")]
	public int question_id
	{
		get
		{
			return this._question_id;
		}
		set
		{
			if ((this._question_id != value))
			{
				if (this._dt_questionOS.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onquestion_idChanging(value);
				this.SendPropertyChanging();
				this._question_id = value;
				this.SendPropertyChanged("question_id");
				this.Onquestion_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dt_questionOS_dt_answerOS", Storage="_dt_questionOS", ThisKey="question_id", OtherKey="id", IsForeignKey=true)]
	public dt_questionOS dt_questionOS
	{
		get
		{
			return this._dt_questionOS.Entity;
		}
		set
		{
			dt_questionOS previousValue = this._dt_questionOS.Entity;
			if (((previousValue != value) 
						|| (this._dt_questionOS.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._dt_questionOS.Entity = null;
					previousValue.dt_answerOS.Remove(this);
				}
				this._dt_questionOS.Entity = value;
				if ((value != null))
				{
					value.dt_answerOS.Add(this);
					this._question_id = value.id;
				}
				else
				{
					this._question_id = default(int);
				}
				this.SendPropertyChanged("dt_questionOS");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dt_membership")]
public partial class dt_membershipOS : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _m_name;
	
	private string _m_password;
	
	private string _real_name;
	
	private string _real_email;
	
	private string _m_info;
	
	private EntitySet<tx_answeredQuestionOS> _tx_answeredQuestionOS;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onm_nameChanging(string value);
    partial void Onm_nameChanged();
    partial void Onm_passwordChanging(string value);
    partial void Onm_passwordChanged();
    partial void Onreal_nameChanging(string value);
    partial void Onreal_nameChanged();
    partial void Onreal_emailChanging(string value);
    partial void Onreal_emailChanged();
    partial void Onm_infoChanging(string value);
    partial void Onm_infoChanged();
    #endregion
	
	public dt_membershipOS()
	{
		this._tx_answeredQuestionOS = new EntitySet<tx_answeredQuestionOS>(new Action<tx_answeredQuestionOS>(this.attach_tx_answeredQuestionOS), new Action<tx_answeredQuestionOS>(this.detach_tx_answeredQuestionOS));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string m_name
	{
		get
		{
			return this._m_name;
		}
		set
		{
			if ((this._m_name != value))
			{
				this.Onm_nameChanging(value);
				this.SendPropertyChanging();
				this._m_name = value;
				this.SendPropertyChanged("m_name");
				this.Onm_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m_password", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
	public string m_password
	{
		get
		{
			return this._m_password;
		}
		set
		{
			if ((this._m_password != value))
			{
				this.Onm_passwordChanging(value);
				this.SendPropertyChanging();
				this._m_password = value;
				this.SendPropertyChanged("m_password");
				this.Onm_passwordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_real_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string real_name
	{
		get
		{
			return this._real_name;
		}
		set
		{
			if ((this._real_name != value))
			{
				this.Onreal_nameChanging(value);
				this.SendPropertyChanging();
				this._real_name = value;
				this.SendPropertyChanged("real_name");
				this.Onreal_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_real_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string real_email
	{
		get
		{
			return this._real_email;
		}
		set
		{
			if ((this._real_email != value))
			{
				this.Onreal_emailChanging(value);
				this.SendPropertyChanging();
				this._real_email = value;
				this.SendPropertyChanged("real_email");
				this.Onreal_emailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m_info", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string m_info
	{
		get
		{
			return this._m_info;
		}
		set
		{
			if ((this._m_info != value))
			{
				this.Onm_infoChanging(value);
				this.SendPropertyChanging();
				this._m_info = value;
				this.SendPropertyChanged("m_info");
				this.Onm_infoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dt_membershipOS_tx_answeredQuestionOS", Storage="_tx_answeredQuestionOS", ThisKey="id", OtherKey="member_id")]
	public EntitySet<tx_answeredQuestionOS> tx_answeredQuestionOS
	{
		get
		{
			return this._tx_answeredQuestionOS;
		}
		set
		{
			this._tx_answeredQuestionOS.Assign(value);
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
	
	private void attach_tx_answeredQuestionOS(tx_answeredQuestionOS entity)
	{
		this.SendPropertyChanging();
		entity.dt_membershipOS = this;
	}
	
	private void detach_tx_answeredQuestionOS(tx_answeredQuestionOS entity)
	{
		this.SendPropertyChanging();
		entity.dt_membershipOS = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dt_questions")]
public partial class dt_questionOS : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private byte _difficulty;
	
	private System.Nullable<int> _topic_id;
	
	private string _question;
	
	private string _answer;
	
	private System.Nullable<byte> _answer_count;
	
	private EntitySet<dt_answerOS> _dt_answerOS;
	
	private EntitySet<tx_answeredQuestionOS> _tx_answeredQuestionOS;
	
	private EntityRef<lu_topicOS> _lu_topicOS;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndifficultyChanging(byte value);
    partial void OndifficultyChanged();
    partial void Ontopic_idChanging(System.Nullable<int> value);
    partial void Ontopic_idChanged();
    partial void OnquestionChanging(string value);
    partial void OnquestionChanged();
    partial void OnanswerChanging(string value);
    partial void OnanswerChanged();
    partial void Onanswer_countChanging(System.Nullable<byte> value);
    partial void Onanswer_countChanged();
    #endregion
	
	public dt_questionOS()
	{
		this._dt_answerOS = new EntitySet<dt_answerOS>(new Action<dt_answerOS>(this.attach_dt_answerOS), new Action<dt_answerOS>(this.detach_dt_answerOS));
		this._tx_answeredQuestionOS = new EntitySet<tx_answeredQuestionOS>(new Action<tx_answeredQuestionOS>(this.attach_tx_answeredQuestionOS), new Action<tx_answeredQuestionOS>(this.detach_tx_answeredQuestionOS));
		this._lu_topicOS = default(EntityRef<lu_topicOS>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_difficulty", DbType="TinyInt NOT NULL")]
	public byte difficulty
	{
		get
		{
			return this._difficulty;
		}
		set
		{
			if ((this._difficulty != value))
			{
				this.OndifficultyChanging(value);
				this.SendPropertyChanging();
				this._difficulty = value;
				this.SendPropertyChanged("difficulty");
				this.OndifficultyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_topic_id", DbType="Int")]
	public System.Nullable<int> topic_id
	{
		get
		{
			return this._topic_id;
		}
		set
		{
			if ((this._topic_id != value))
			{
				if (this._lu_topicOS.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Ontopic_idChanging(value);
				this.SendPropertyChanging();
				this._topic_id = value;
				this.SendPropertyChanged("topic_id");
				this.Ontopic_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_question", DbType="NVarChar(100)")]
	public string question
	{
		get
		{
			return this._question;
		}
		set
		{
			if ((this._question != value))
			{
				this.OnquestionChanging(value);
				this.SendPropertyChanging();
				this._question = value;
				this.SendPropertyChanged("question");
				this.OnquestionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer", DbType="NVarChar(50)")]
	public string answer
	{
		get
		{
			return this._answer;
		}
		set
		{
			if ((this._answer != value))
			{
				this.OnanswerChanging(value);
				this.SendPropertyChanging();
				this._answer = value;
				this.SendPropertyChanged("answer");
				this.OnanswerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer_count", DbType="TinyInt")]
	public System.Nullable<byte> answer_count
	{
		get
		{
			return this._answer_count;
		}
		set
		{
			if ((this._answer_count != value))
			{
				this.Onanswer_countChanging(value);
				this.SendPropertyChanging();
				this._answer_count = value;
				this.SendPropertyChanged("answer_count");
				this.Onanswer_countChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dt_questionOS_dt_answerOS", Storage="_dt_answerOS", ThisKey="id", OtherKey="question_id")]
	public EntitySet<dt_answerOS> dt_answerOS
	{
		get
		{
			return this._dt_answerOS;
		}
		set
		{
			this._dt_answerOS.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dt_questionOS_tx_answeredQuestionOS", Storage="_tx_answeredQuestionOS", ThisKey="id", OtherKey="question_id")]
	public EntitySet<tx_answeredQuestionOS> tx_answeredQuestionOS
	{
		get
		{
			return this._tx_answeredQuestionOS;
		}
		set
		{
			this._tx_answeredQuestionOS.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="lu_topicOS_dt_questionOS", Storage="_lu_topicOS", ThisKey="topic_id", OtherKey="id", IsForeignKey=true)]
	public lu_topicOS lu_topicOS
	{
		get
		{
			return this._lu_topicOS.Entity;
		}
		set
		{
			lu_topicOS previousValue = this._lu_topicOS.Entity;
			if (((previousValue != value) 
						|| (this._lu_topicOS.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._lu_topicOS.Entity = null;
					previousValue.dt_questionOS.Remove(this);
				}
				this._lu_topicOS.Entity = value;
				if ((value != null))
				{
					value.dt_questionOS.Add(this);
					this._topic_id = value.id;
				}
				else
				{
					this._topic_id = default(Nullable<int>);
				}
				this.SendPropertyChanged("lu_topicOS");
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
	
	private void attach_dt_answerOS(dt_answerOS entity)
	{
		this.SendPropertyChanging();
		entity.dt_questionOS = this;
	}
	
	private void detach_dt_answerOS(dt_answerOS entity)
	{
		this.SendPropertyChanging();
		entity.dt_questionOS = null;
	}
	
	private void attach_tx_answeredQuestionOS(tx_answeredQuestionOS entity)
	{
		this.SendPropertyChanging();
		entity.dt_questionOS = this;
	}
	
	private void detach_tx_answeredQuestionOS(tx_answeredQuestionOS entity)
	{
		this.SendPropertyChanging();
		entity.dt_questionOS = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lu_lesson")]
public partial class lu_lessonOS : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _text;
	
	private EntitySet<lu_topicOS> _lu_topicOS;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    #endregion
	
	public lu_lessonOS()
	{
		this._lu_topicOS = new EntitySet<lu_topicOS>(new Action<lu_topicOS>(this.attach_lu_topicOS), new Action<lu_topicOS>(this.detach_lu_topicOS));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string text
	{
		get
		{
			return this._text;
		}
		set
		{
			if ((this._text != value))
			{
				this.OntextChanging(value);
				this.SendPropertyChanging();
				this._text = value;
				this.SendPropertyChanged("text");
				this.OntextChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="lu_lessonOS_lu_topicOS", Storage="_lu_topicOS", ThisKey="id", OtherKey="lesson_id")]
	public EntitySet<lu_topicOS> lu_topicOS
	{
		get
		{
			return this._lu_topicOS;
		}
		set
		{
			this._lu_topicOS.Assign(value);
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
	
	private void attach_lu_topicOS(lu_topicOS entity)
	{
		this.SendPropertyChanging();
		entity.lu_lessonOS = this;
	}
	
	private void detach_lu_topicOS(lu_topicOS entity)
	{
		this.SendPropertyChanging();
		entity.lu_lessonOS = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lu_topic")]
public partial class lu_topicOS : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _text;
	
	private int _lesson_id;
	
	private EntitySet<dt_questionOS> _dt_questionOS;
	
	private EntityRef<lu_lessonOS> _lu_lessonOS;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void Onlesson_idChanging(int value);
    partial void Onlesson_idChanged();
    #endregion
	
	public lu_topicOS()
	{
		this._dt_questionOS = new EntitySet<dt_questionOS>(new Action<dt_questionOS>(this.attach_dt_questionOS), new Action<dt_questionOS>(this.detach_dt_questionOS));
		this._lu_lessonOS = default(EntityRef<lu_lessonOS>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string text
	{
		get
		{
			return this._text;
		}
		set
		{
			if ((this._text != value))
			{
				this.OntextChanging(value);
				this.SendPropertyChanging();
				this._text = value;
				this.SendPropertyChanged("text");
				this.OntextChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lesson_id", DbType="Int NOT NULL")]
	public int lesson_id
	{
		get
		{
			return this._lesson_id;
		}
		set
		{
			if ((this._lesson_id != value))
			{
				if (this._lu_lessonOS.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onlesson_idChanging(value);
				this.SendPropertyChanging();
				this._lesson_id = value;
				this.SendPropertyChanged("lesson_id");
				this.Onlesson_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="lu_topicOS_dt_questionOS", Storage="_dt_questionOS", ThisKey="id", OtherKey="topic_id")]
	public EntitySet<dt_questionOS> dt_questionOS
	{
		get
		{
			return this._dt_questionOS;
		}
		set
		{
			this._dt_questionOS.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="lu_lessonOS_lu_topicOS", Storage="_lu_lessonOS", ThisKey="lesson_id", OtherKey="id", IsForeignKey=true)]
	public lu_lessonOS lu_lessonOS
	{
		get
		{
			return this._lu_lessonOS.Entity;
		}
		set
		{
			lu_lessonOS previousValue = this._lu_lessonOS.Entity;
			if (((previousValue != value) 
						|| (this._lu_lessonOS.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._lu_lessonOS.Entity = null;
					previousValue.lu_topicOS.Remove(this);
				}
				this._lu_lessonOS.Entity = value;
				if ((value != null))
				{
					value.lu_topicOS.Add(this);
					this._lesson_id = value.id;
				}
				else
				{
					this._lesson_id = default(int);
				}
				this.SendPropertyChanged("lu_lessonOS");
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
	
	private void attach_dt_questionOS(dt_questionOS entity)
	{
		this.SendPropertyChanging();
		entity.lu_topicOS = this;
	}
	
	private void detach_dt_questionOS(dt_questionOS entity)
	{
		this.SendPropertyChanging();
		entity.lu_topicOS = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tx_answeredQuestions")]
public partial class tx_answeredQuestionOS : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private int _member_id;
	
	private int _question_id;
	
	private System.DateTime _date;
	
	private bool _correct;
	
	private System.Nullable<System.TimeSpan> _time;
	
	private EntityRef<dt_membershipOS> _dt_membershipOS;
	
	private EntityRef<dt_questionOS> _dt_questionOS;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onmember_idChanging(int value);
    partial void Onmember_idChanged();
    partial void Onquestion_idChanging(int value);
    partial void Onquestion_idChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OncorrectChanging(bool value);
    partial void OncorrectChanged();
    partial void OntimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OntimeChanged();
    #endregion
	
	public tx_answeredQuestionOS()
	{
		this._dt_membershipOS = default(EntityRef<dt_membershipOS>);
		this._dt_questionOS = default(EntityRef<dt_questionOS>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_member_id", DbType="Int NOT NULL")]
	public int member_id
	{
		get
		{
			return this._member_id;
		}
		set
		{
			if ((this._member_id != value))
			{
				if (this._dt_membershipOS.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onmember_idChanging(value);
				this.SendPropertyChanging();
				this._member_id = value;
				this.SendPropertyChanged("member_id");
				this.Onmember_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_question_id", DbType="Int NOT NULL")]
	public int question_id
	{
		get
		{
			return this._question_id;
		}
		set
		{
			if ((this._question_id != value))
			{
				if (this._dt_questionOS.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onquestion_idChanging(value);
				this.SendPropertyChanging();
				this._question_id = value;
				this.SendPropertyChanged("question_id");
				this.Onquestion_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
	public System.DateTime date
	{
		get
		{
			return this._date;
		}
		set
		{
			if ((this._date != value))
			{
				this.OndateChanging(value);
				this.SendPropertyChanging();
				this._date = value;
				this.SendPropertyChanged("date");
				this.OndateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correct", DbType="Bit NOT NULL")]
	public bool correct
	{
		get
		{
			return this._correct;
		}
		set
		{
			if ((this._correct != value))
			{
				this.OncorrectChanging(value);
				this.SendPropertyChanging();
				this._correct = value;
				this.SendPropertyChanged("correct");
				this.OncorrectChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="Time")]
	public System.Nullable<System.TimeSpan> time
	{
		get
		{
			return this._time;
		}
		set
		{
			if ((this._time != value))
			{
				this.OntimeChanging(value);
				this.SendPropertyChanging();
				this._time = value;
				this.SendPropertyChanged("time");
				this.OntimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dt_membershipOS_tx_answeredQuestionOS", Storage="_dt_membershipOS", ThisKey="member_id", OtherKey="id", IsForeignKey=true)]
	public dt_membershipOS dt_membershipOS
	{
		get
		{
			return this._dt_membershipOS.Entity;
		}
		set
		{
			dt_membershipOS previousValue = this._dt_membershipOS.Entity;
			if (((previousValue != value) 
						|| (this._dt_membershipOS.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._dt_membershipOS.Entity = null;
					previousValue.tx_answeredQuestionOS.Remove(this);
				}
				this._dt_membershipOS.Entity = value;
				if ((value != null))
				{
					value.tx_answeredQuestionOS.Add(this);
					this._member_id = value.id;
				}
				else
				{
					this._member_id = default(int);
				}
				this.SendPropertyChanged("dt_membershipOS");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dt_questionOS_tx_answeredQuestionOS", Storage="_dt_questionOS", ThisKey="question_id", OtherKey="id", IsForeignKey=true)]
	public dt_questionOS dt_questionOS
	{
		get
		{
			return this._dt_questionOS.Entity;
		}
		set
		{
			dt_questionOS previousValue = this._dt_questionOS.Entity;
			if (((previousValue != value) 
						|| (this._dt_questionOS.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._dt_questionOS.Entity = null;
					previousValue.tx_answeredQuestionOS.Remove(this);
				}
				this._dt_questionOS.Entity = value;
				if ((value != null))
				{
					value.tx_answeredQuestionOS.Add(this);
					this._question_id = value.id;
				}
				else
				{
					this._question_id = default(int);
				}
				this.SendPropertyChanged("dt_questionOS");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dt_memberTopic")]
public partial class dt_memberTopicOS : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private int _member_id;
	
	private int _topic_id;
	
	private System.Nullable<double> _puan;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onmember_idChanging(int value);
    partial void Onmember_idChanged();
    partial void Ontopic_idChanging(int value);
    partial void Ontopic_idChanged();
    partial void OnpuanChanging(System.Nullable<double> value);
    partial void OnpuanChanged();
    #endregion
	
	public dt_memberTopicOS()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_member_id", DbType="Int NOT NULL")]
	public int member_id
	{
		get
		{
			return this._member_id;
		}
		set
		{
			if ((this._member_id != value))
			{
				this.Onmember_idChanging(value);
				this.SendPropertyChanging();
				this._member_id = value;
				this.SendPropertyChanged("member_id");
				this.Onmember_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_topic_id", DbType="Int NOT NULL")]
	public int topic_id
	{
		get
		{
			return this._topic_id;
		}
		set
		{
			if ((this._topic_id != value))
			{
				this.Ontopic_idChanging(value);
				this.SendPropertyChanging();
				this._topic_id = value;
				this.SendPropertyChanged("topic_id");
				this.Ontopic_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_puan", DbType="Float")]
	public System.Nullable<double> puan
	{
		get
		{
			return this._puan;
		}
		set
		{
			if ((this._puan != value))
			{
				this.OnpuanChanging(value);
				this.SendPropertyChanging();
				this._puan = value;
				this.SendPropertyChanged("puan");
				this.OnpuanChanged();
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
#pragma warning restore 1591