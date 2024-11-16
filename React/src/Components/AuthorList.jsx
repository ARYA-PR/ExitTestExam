import React, { useEffect, useState } from 'react'

const AuthorList = () => {
    const[authors,setAuthors]=useState([]);
    const[name,setName]=useState([]);
    const[bio,setBio]=useState([]);
    useEffect(() => {
        const fetchAuthors = async () => {
            const response = await axios.get('http://localhost:5208/api/Authors');
            setAuthors(response.data);
        };
        fetchAuthors();
    }, []);
    
    const addAuthor = async (e) => {
        e.preventDefault();
        const newAuthor = { name, bio };
        await axios.post('http://localhost:5208/api/Authors', newAuthor);
        setAuthors([...authors, newAuthor]);
        setName('');
        setBio('');
    };
    
    
    
    
    return (
        <div>
            <h1>Authors</h1>
            <form onSubmit={addAuthor}>
                <input
                    type="text"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                    placeholder="Author Name"
                    required
                />
                <input
                    type="text"
                    value={bio}
                    onChange={(e) => setBio(e.target.value)}
                    placeholder="Bio"
                />
                <button type="submit">Add Author</button>
            </form>
            <ul>
                {authors.map((author) => (
                    <li key={author.id}>{author.name}</li>
                ))}
            </ul>
        </div>
    );
};
export default AuthorList
