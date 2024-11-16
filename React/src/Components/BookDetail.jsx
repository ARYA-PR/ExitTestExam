import React from 'react'

const BookDetail = () => {
    if (!book) return <div>Select a book to see its details.</div>;

    return (
        <div>
            <h2>{book.title}</h2>
            <p>{book.description}</p>
            <p><strong>Publication Year:</strong> {book.publicationYear}</p>
            <p><strong>Author:</strong> {book.author.name}</p>
            <p><strong>Category:</strong> {book.category.name}</p>
        </div>
    );
};

export default BookDetail
