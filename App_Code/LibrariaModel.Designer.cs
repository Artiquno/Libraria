﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LibrariaModel", "Users_Books", "Books", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(LibrariaModel.Book), "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(LibrariaModel.User))]

#endregion

namespace LibrariaModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LibrariaEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LibrariaEntities object using the connection string found in the 'LibrariaEntities' section of the application configuration file.
        /// </summary>
        public LibrariaEntities() : base("name=LibrariaEntities", "LibrariaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibrariaEntities object.
        /// </summary>
        public LibrariaEntities(string connectionString) : base(connectionString, "LibrariaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibrariaEntities object.
        /// </summary>
        public LibrariaEntities(EntityConnection connection) : base(connection, "LibrariaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibrariaModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="bookUrl">Initial value of the BookUrl property.</param>
        /// <param name="timesRead">Initial value of the TimesRead property.</param>
        public static Book CreateBook(global::System.Int64 id, global::System.String title, global::System.String author, global::System.String bookUrl, global::System.Int32 timesRead)
        {
            Book book = new Book();
            book.Id = id;
            book.Title = title;
            book.Author = author;
            book.BookUrl = bookUrl;
            book.TimesRead = timesRead;
            return book;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ISBN10
        {
            get
            {
                return _ISBN10;
            }
            set
            {
                OnISBN10Changing(value);
                ReportPropertyChanging("ISBN10");
                _ISBN10 = StructuralObject.SetValidValue(value, true, "ISBN10");
                ReportPropertyChanged("ISBN10");
                OnISBN10Changed();
            }
        }
        private global::System.String _ISBN10;
        partial void OnISBN10Changing(global::System.String value);
        partial void OnISBN10Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ISBN13
        {
            get
            {
                return _ISBN13;
            }
            set
            {
                OnISBN13Changing(value);
                ReportPropertyChanging("ISBN13");
                _ISBN13 = StructuralObject.SetValidValue(value, true, "ISBN13");
                ReportPropertyChanged("ISBN13");
                OnISBN13Changed();
            }
        }
        private global::System.String _ISBN13;
        partial void OnISBN13Changing(global::System.String value);
        partial void OnISBN13Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false, "Author");
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                OnGenreChanging(value);
                ReportPropertyChanging("Genre");
                _Genre = StructuralObject.SetValidValue(value, true, "Genre");
                ReportPropertyChanged("Genre");
                OnGenreChanged();
            }
        }
        private global::System.String _Genre;
        partial void OnGenreChanging(global::System.String value);
        partial void OnGenreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookUrl
        {
            get
            {
                return _BookUrl;
            }
            set
            {
                OnBookUrlChanging(value);
                ReportPropertyChanging("BookUrl");
                _BookUrl = StructuralObject.SetValidValue(value, false, "BookUrl");
                ReportPropertyChanged("BookUrl");
                OnBookUrlChanged();
            }
        }
        private global::System.String _BookUrl;
        partial void OnBookUrlChanging(global::System.String value);
        partial void OnBookUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CoverUrl
        {
            get
            {
                return _CoverUrl;
            }
            set
            {
                OnCoverUrlChanging(value);
                ReportPropertyChanging("CoverUrl");
                _CoverUrl = StructuralObject.SetValidValue(value, true, "CoverUrl");
                ReportPropertyChanged("CoverUrl");
                OnCoverUrlChanged();
            }
        }
        private global::System.String _CoverUrl;
        partial void OnCoverUrlChanging(global::System.String value);
        partial void OnCoverUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TimesRead
        {
            get
            {
                return _TimesRead;
            }
            set
            {
                OnTimesReadChanging(value);
                ReportPropertyChanging("TimesRead");
                _TimesRead = StructuralObject.SetValidValue(value, "TimesRead");
                ReportPropertyChanged("TimesRead");
                OnTimesReadChanged();
            }
        }
        private global::System.Int32 _TimesRead;
        partial void OnTimesReadChanging(global::System.Int32 value);
        partial void OnTimesReadChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibrariaModel", "Users_Books", "Users")]
        public EntityCollection<User> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<User>("LibrariaModel.Users_Books", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<User>("LibrariaModel.Users_Books", "Users", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibrariaModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="username">Initial value of the Username property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="admin">Initial value of the Admin property.</param>
        public static User CreateUser(global::System.Int64 id, global::System.String username, global::System.String password, global::System.Boolean admin)
        {
            User user = new User();
            user.Id = id;
            user.Username = username;
            user.Password = password;
            user.Admin = admin;
            return user;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, false, "Username");
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false, "Password");
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Admin
        {
            get
            {
                return _Admin;
            }
            set
            {
                OnAdminChanging(value);
                ReportPropertyChanging("Admin");
                _Admin = StructuralObject.SetValidValue(value, "Admin");
                ReportPropertyChanged("Admin");
                OnAdminChanged();
            }
        }
        private global::System.Boolean _Admin;
        partial void OnAdminChanging(global::System.Boolean value);
        partial void OnAdminChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibrariaModel", "Users_Books", "Books")]
        public EntityCollection<Book> Books
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Book>("LibrariaModel.Users_Books", "Books");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Book>("LibrariaModel.Users_Books", "Books", value);
                }
            }
        }

        #endregion

    }

    #endregion

}