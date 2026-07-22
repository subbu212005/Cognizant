# Angular Quiz – Questions, Answers & Explanations

## 1. Angular is primarily considered as?
- ✅ A. A JavaScript Framework
- B. A CSS Framework
- C. A content management system
- D. A database system

**Answer:** A. A JavaScript Framework

**Explanation:** Angular is a framework for building client-side web applications using TypeScript, HTML, and CSS.

---

## 2. Which command is used to create a new Angular project?
- A. npm create angular-app
- ✅ B. ng new project-name
- C. angular init project-name
- D. npm start angular

**Answer:** B. ng new project-name

**Explanation:** The `ng new` command creates a new Angular project with all required files and dependencies.

---

## 3. Which of the following is a core component in an Angular application?
- A. ViewController
- ✅ B. Directive
- C. Activity
- D. Observer

**Answer:** B. Directive

**Explanation:** Directives are one of Angular's core building blocks used to extend HTML functionality.

---

## 4. How do you bind data to an attribute in Angular?
- A. {{variable}}
- B. (variable)
- ✅ C. [variable]
- D. =variable=

**Answer:** C. [variable]

**Explanation:** Square brackets `[]` are used for property (attribute) binding.

---

## 5. Which Angular decorator is used to listen to DOM events?
- A. @Output()
- B. @Input()
- C. @Event()
- ✅ D. @HostListener()

**Answer:** D. @HostListener()

**Explanation:** `@HostListener()` listens for events on the host element.

---

## 6. Which directive is used in Angular to add/remove an HTML element from the DOM based on a condition?
- A. *ngFor
- B. *ngSelect
- C. *ngSwitch
- ✅ D. *ngIf

**Answer:** D. *ngIf

**Explanation:** `*ngIf` conditionally adds or removes elements from the DOM.

---

## 7. How can you fetch data from a server or database in Angular?
- ✅ A. Using the HTTPModule
- B. Using the FetchAPI
- C. Using the ServerModule
- D. Using the DatabaseModule

**Answer:** A. Using the HTTPModule *(Modern Angular uses HttpClientModule.)*

**Explanation:** In current Angular versions, `HttpClientModule` and `HttpClient` are recommended.

---

## 8. What does a pipe do in Angular?
- A. Connects two components
- ✅ B. Transforms data in the template
- C. Merges streams of data
- D. Opens a direct connection to the server

**Answer:** B. Transforms data in the template

**Explanation:** Pipes format and transform displayed data.

---

## 9. Which decorator allows communication from a child component to its parent?
- A. @Input()
- ✅ B. @Output()
- C. @ViewChild()
- D. @Connect()

**Answer:** B. @Output()

**Explanation:** `@Output()` with `EventEmitter` sends events to the parent component.

---

## 10. In which lifecycle hook is it recommended to send HTTP requests in an Angular component?
- A. constructor
- ✅ B. ngOnInit
- C. ngOnDestroy
- D. ngAfterViewInit

**Answer:** B. ngOnInit

**Explanation:** Initialization logic and API calls should be placed in `ngOnInit()`.

---

## 11. What purpose does the ngModel directive serve?
- A. Handling HTTP requests
- ✅ B. Data binding for both input and output
- C. Listening to DOM events
- D. Controlling animation

**Answer:** B. Data binding for both input and output

**Explanation:** `[(ngModel)]` enables two-way data binding.

---

## 12. How can you generate a new service using Angular CLI?
- A. ng create service my-service
- ✅ B. ng generate service my-service
- C. ng new service my-service
- D. ng add service my-service

**Answer:** B. ng generate service my-service

**Explanation:** `ng generate service` or `ng g s` creates a service.

---

## 13. What is the use of Angular Directives?
- A. To inject services
- B. To initialize component state
- ✅ C. To manipulate the DOM elements
- D. To store data

**Answer:** C. To manipulate the DOM elements

**Explanation:** Directives modify the appearance or behavior of DOM elements.

---

## 14. Which Angular decorator is used for making a class a root module?
- A. @Module()
- B. @Component()
- C. @Directive()
- ✅ D. @NgModule()

**Answer:** D. @NgModule()

**Explanation:** `@NgModule()` defines an Angular module.

---

## 15. Which is the correct syntax for an Angular Event binding?
- A. {click}="doSomething()"
- B. on-click="doSomething()"
- ✅ C. (click)="doSomething()"
- D. click[]="doSomething()"

**Answer:** C. (click)="doSomething()"

**Explanation:** Parentheses `()` are used for event binding.

---

## 16. Which command is used to install Angular CLI globally?
- A. npm install @angular/cli
- B. npm global install @angular/cli
- ✅ C. npm install -g @angular/cli
- D. npm --install @angular/cli

**Answer:** C. npm install -g @angular/cli

---

## 17. How do you define a route in Angular?
- A. Using `<a>` tags
- B. Using the Router service
- ✅ C. Using the Routes array
- D. Using the @Route() decorator

**Answer:** C. Using the Routes array

**Explanation:** Angular routes are configured using a `Routes` array.

---

## 18. What's the primary purpose of the ngOnInit lifecycle hook in Angular components?
- ✅ A. Initialization and data retrieval
- B. Destruction of instances
- C. Manipulation of the view's DOM
- D. Handling of user input

**Answer:** A. Initialization and data retrieval

---

## 19. Which decorator allows you to define styles for a component?
- A. @Style()
- B. @ViewStyle()
- C. @ComponentStyle()
- ✅ D. @Component({ styles: [...] })

**Answer:** D. @Component({ styles: [...] })

---

## 20. What is the main difference between constructor and ngOnInit in Angular?
- A. They serve the same purpose
- B. constructor is used for initialization, while ngOnInit is used for destruction
- ✅ C. constructor is used for dependency injection, while ngOnInit is used for initialization logic
- D. ngOnInit is used for dependency injection, while the constructor is used for initialization logic

**Answer:** C.

---

## 21. What is the purpose of the async pipe in Angular?
- A. To make asynchronous HTTP requests
- ✅ B. To automatically unsubscribe from observables or promises
- C. To pause the execution of the application
- D. To run change detection asynchronously

**Answer:** B.

---

## 22. Which directive is used in Angular to loop through an array or object?
- ✅ A. ngFor
- B. ngIf
- C. ngSwitch
- D. ngWhile

**Answer:** A. ngFor

---

## 23. What is the primary purpose of NgModules in Angular?
- A. Error handling
- B. Two-way data binding
- ✅ C. To group together components, directives, and services that are related
- D. To enhance performance

**Answer:** C.

---

## 24. How can you bind to an input box value in Angular?
- A. Using ngValue
- B. Using ngBind
- C. Using [(value)]
- ✅ D. Using [(ngModel)]

**Answer:** D.

---

## 25. In Angular, which directive is used to apply styles conditionally?
- A. ngStyle
- ✅ B. ngClass
- C. ngIf
- D. ngApply

**Answer:** B. ngClass

---

## 26. Which decorator is used to listen to host events in an Angular directive?
- A. @EventListener
- B. @HostBinding
- ✅ C. @HostListener
- D. @Listen

**Answer:** C. @HostListener

---

## 27. How do you fetch data from a server or API in Angular?
- A. Using the XMLHttpRequest object
- ✅ B. Using the HttpClient module
- C. Using the fetchData method
- D. Using the AjaxModule

**Answer:** B. Using the HttpClient module

---

## 28. What decorator is used to create a service in Angular?
- A. @Directive
- B. @Component
- ✅ C. @Injectable
- D. @Service

**Answer:** C. @Injectable

---

## 29. Which module in Angular includes basic directives like ngIf and ngFor?
- A. BrowserModule
- B. FormsModule
- C. AppModule
- ✅ D. CommonModule

**Answer:** D. CommonModule

---

## 30. Which decorator in Angular is used to get data from a parent component?
- ✅ A. @Input
- B. @Output
- C. @ViewChild
- D. @GetData

**Answer:** A. @Input

**Explanation:** `@Input()` allows a child component to receive data from its parent component.
