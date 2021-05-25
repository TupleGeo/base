﻿
#region Header
// Title Name       : CentralizedChangesObserver2.
// Member of        : TupleGeo.Apps.Presentation.dll
// Description      : The CentralizedChangesObserver2 is an observer inherited from ChangesObserver which
//                    provides listeners/handlers for property and collection changes that are managed centrally.
// Created by       : 22/05/2021, 16:09, Vasilis Vlastaras.
// Updated by       : 
// Version          : 1.0.0
// Contact Details  : TupleGeo.
// License          : Apache License.
// Copyright        : TupleGeo, 2021.
// Comments         : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using TupleGeo.General.Linq.Expressions;

#endregion

namespace TupleGeo.Apps.Presentation.Observers {

  /// <summary>
  /// The CentralizedChangesObserver2 is an observer inherited from ChangesObserver which
  /// provides listeners/handlers for property and collection changes that are managed centrally.
  /// </summary>
  public sealed class CentralizedChangesObserver2 : IChangesObserverMethods<CentralizedChangesObserver2> {

    #region Imported Namespaces

    private readonly WeakEventManager<PropertyChangedEventArgs> _weakPropertyChangedEventManager;
    private readonly WeakEventManager<NotifyCollectionChangedEventArgs> _weakCollectionChangedEventManager;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CentralizedChangesObserver2"/>.
    /// </summary>
    public CentralizedChangesObserver2() {
      this._weakPropertyChangedEventManager = new WeakEventManager<PropertyChangedEventArgs>(OnPropertyChanged);
      this._weakCollectionChangedEventManager = new WeakEventManager<NotifyCollectionChangedEventArgs>(OnCollectionChanged);
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// <para>Fires when a property has been changed.</para>
    /// <para>Override this to listen to property changes and to provide custom reaction logic to these changes.</para>
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="propertyChangedEventArgs">The PropertyChangedEventArgs.</param>
    public void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) {

    }

    /// <summary>
    /// <para>Fires when a collection has been changed.</para>
    /// <para>Override this to listen to property changes and to provide custom reaction logic to these changes.</para>
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="notifyCollectionChangedEventArgs">The NotifyCollectionChangedEventArgs.</param>
    public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs) {

    }

    #endregion

    #region Event Procedures

    /// <summary>
    /// Occurs when the ObservableObject has been changed.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The PropertyChangedEventArgs.</param>
    private void ObservableObject_PropertyChanged(object sender, PropertyChangedEventArgs e) {
      OnPropertyChanged(sender, e);
    }

    /// <summary>
    /// Occurs when the ObservableCollection has been changed.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The NotifyCollectionChangedEventArgs.</param>
    private void ObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
      OnCollectionChanged(sender, e);
    }

    #endregion

    #region IObservationMethods<CentralizedChangesObserver> Members

    /// <summary>
    /// Adds a weak listener to the property of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="property">The property of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddPropertyChangedListener<TModel>(INotifyPropertyChanged source, Expression<Func<TModel, object>> property) where TModel : IModel {

      string propertyName = Prop.GetPropertyName<TModel>(property);
      PropertyChangedEventManager.AddListener(source, _weakPropertyChangedEventManager, propertyName);

      return this;

    }

    /// <summary>
    /// Removes a weak listener from the property of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="property">The property of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemovePropertyChangedListener<TModel>(INotifyPropertyChanged source, Expression<Func<TModel, object>> property) where TModel : IModel {

      string propertyName = Prop.GetPropertyName<TModel>(property);
      PropertyChangedEventManager.RemoveListener(source, _weakPropertyChangedEventManager, propertyName);

      return this;

    }

    /// <summary>
    /// Adds a weak listener to the property of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="propertyName">The property name of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddPropertyChangedListener<TModel>(INotifyPropertyChanged source, string propertyName) where TModel : IModel {

      PropertyChangedEventManager.AddListener(source, _weakPropertyChangedEventManager, propertyName);

      return this;

    }

    /// <summary>
    /// Removes a weak listener from the property of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="propertyName">The property name of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemovePropertyChangedListener<TModel>(INotifyPropertyChanged source, string propertyName) where TModel : IModel {

      PropertyChangedEventManager.AddListener(source, _weakPropertyChangedEventManager, propertyName);

      return this;

    }

    /// <summary>
    /// Adds a weak listener to all the properties of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddPropertyChangedListener<TModel>(INotifyPropertyChanged source) where TModel : IModel {

      PropertyChangedEventManager.AddListener(source, _weakPropertyChangedEventManager, string.Empty);

      return this;

    }

    /// <summary>
    /// Removes a weak listener from the properties of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemovePropertyChangedListener<TModel>(INotifyPropertyChanged source) where TModel : IModel {

      PropertyChangedEventManager.RemoveListener(source, _weakPropertyChangedEventManager, string.Empty);

      return this;

    }

    /// <summary>
    /// Adds an event handler to the property of an object that implement the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="property">The property of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddPropertyChangedHandler<TModel>(INotifyPropertyChanged source, Expression<Func<TModel, object>> property) where TModel : IModel {

      string propertyName = Prop.GetPropertyName<TModel>(property);
      PropertyChangedEventManager.AddHandler(source, ObservableObject_PropertyChanged, propertyName);

      return this;

    }

    /// <summary>
    /// Removes an event handler from the property of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="property">The property of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemovePropertyChangedHandler<TModel>(INotifyPropertyChanged source, Expression<Func<TModel, object>> property) where TModel : IModel {

      string propertyName = Prop.GetPropertyName<TModel>(property);
      PropertyChangedEventManager.RemoveHandler(source, ObservableObject_PropertyChanged, propertyName);

      return this;

    }

    /// <summary>
    /// Adds an event handler to the property of an object that implement the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="propertyName">The property name of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddPropertyChangedHandler<TModel>(INotifyPropertyChanged source, string propertyName) where TModel : IModel {

      PropertyChangedEventManager.AddHandler(source, ObservableObject_PropertyChanged, propertyName);

      return this;

    }

    /// <summary>
    /// Removes an event handler from the property of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <param name="propertyName">The property name of the <typeparamref name="TModel"/>.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemovePropertyChangedHandler<TModel>(INotifyPropertyChanged source, string propertyName) where TModel : IModel {

      PropertyChangedEventManager.RemoveHandler(source, ObservableObject_PropertyChanged, propertyName);

      return this;

    }

    /// <summary>
    /// Adds an event handler to all the properties of an object that implement the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddPropertyChangedHandler<TModel>(INotifyPropertyChanged source) where TModel : IModel {

      PropertyChangedEventManager.AddHandler(source, ObservableObject_PropertyChanged, string.Empty);

      return this;

    }

    /// <summary>
    /// Removes an event handler from all the properties of an object that implements the <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemovePropertyChangedHandler<TModel>(INotifyPropertyChanged source) where TModel : IModel {

      PropertyChangedEventManager.RemoveHandler(source, ObservableObject_PropertyChanged, string.Empty);

      return this;

    }

    /// <summary>
    /// Adds a weak listener to a collection implementing the <see cref="INotifyCollectionChanged"/>.
    /// </summary>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddCollectionChangedListener(INotifyCollectionChanged source) {

      CollectionChangedEventManager.AddListener(source, _weakCollectionChangedEventManager);

      return this;

    }

    /// <summary>
    /// Removes a weak listener from a collection implementing the <see cref="INotifyCollectionChanged"/>.
    /// </summary>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemoveCollectionChangedListener(INotifyCollectionChanged source) {

      CollectionChangedEventManager.RemoveListener(source, _weakCollectionChangedEventManager);

      return this;

    }

    /// <summary>
    /// Adds an event handler to a collection implementing the <see cref="INotifyCollectionChanged"/>.
    /// </summary>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddCollectionChangedHandler(INotifyCollectionChanged source) {

      CollectionChangedEventManager.AddHandler(source, ObservableCollection_CollectionChanged);

      return this;

    }

    /// <summary>
    /// Removes an event handler from a collection implementing the <see cref="INotifyCollectionChanged"/>.
    /// </summary>
    /// <param name="source">The source of the property that has been changed.</param>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemoveCollectionChangedHandler(INotifyCollectionChanged source) {

      CollectionChangedEventManager.RemoveHandler(source, ObservableCollection_CollectionChanged);

      return this;

    }

    /// <summary>
    /// Adds a listener to an <see cref="ObservableCollection{TModel}">ObservableCollection</see> of <typeparamref name="TModel"/>.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="observableCollection">The observable collection used.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="observableCollection"/> is <c>null</c>.
    /// </exception>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 AddObservableCollectionChangedHandler<TModel>(ObservableCollection<TModel> observableCollection) where TModel : IModel {

      CollectionChangedEventManager.AddHandler(observableCollection, ObservableCollection_CollectionChanged);

      return this;

    }

    /// <summary>
    /// Removes a listener to an <see cref="ObservableCollection{TModel}">ObservableCollection</see> of <typeparamref name="TModel"/>.
    /// </summary>
    /// <typeparam name="TModel">The entity used.</typeparam>
    /// <param name="observableCollection">The observable collection used.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="observableCollection"/> is <c>null</c>.
    /// </exception>
    /// <remarks>The method can be used to chain together multiple calls of <see cref="CentralizedChangesObserver2"/> methods.</remarks>
    /// <returns>Itself (<see cref="CentralizedChangesObserver2"/>).</returns>
    public CentralizedChangesObserver2 RemoveObservableCollectionChangedHandler<TModel>(ObservableCollection<TModel> observableCollection) where TModel : IModel {

      CollectionChangedEventManager.RemoveHandler(observableCollection, ObservableCollection_CollectionChanged);

      return this;

    }

    #endregion

  }

}
