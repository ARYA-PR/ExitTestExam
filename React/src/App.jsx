import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import AuthorList from './Components/AuthorList'
import CategoryList from './Components/CategoryList'
import BookList from './Components/BookList'


function App() {
  
  return (
    <div className="App">
        <h1>Library Management System</h1>
        <h2>Manage Authors</h2>
       <AuthorList/>
       <h2>Manage Categories</h2>
            <CategoryList/>
            <h2>Manage Books</h2>
            <BookList/>
    </div>
);
}

export default App
