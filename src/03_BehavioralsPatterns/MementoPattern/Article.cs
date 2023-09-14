using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MementoPattern
{
    // Originator
    public class Article
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return $"{Title} {Content}";
        }

        // Backup
        public ArticleMemento CreateMemento()
        {
            return new ArticleMemento(this.Content, this.Title);
        }

        // Restore
        public void SetMemento(ArticleMemento memento)
        {
            this.Content = memento.Content;
            this.Title = memento.Title;
        }
    }

    // Migawka (snapshot)
    public class ArticleMemento
    {
        public string Content { get; }
        public string Title { get; }
        public DateTime SnapshotDate { get; }

        public ArticleMemento(string content, string title)
        {
            Content = content;
            Title = title;
            SnapshotDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{SnapshotDate} {Title} {Content}";
        }
    }

    // Abstract Caretaker (nadzorca)
    public interface IArticleCaretaker
    {
        void SetState(ArticleMemento memento);
        ArticleMemento GetState();

        IEnumerable<ArticleMemento> History { get; }
    }

    public static class Extension
    {
        public static IEnumerable<T> ToEnumerable<T>(this T item) => new List<T> { item };
    }

    // Concrete Caretaker A
    public class LastArticleCaretaker : IArticleCaretaker
    {
        private ArticleMemento _memento;

        public IEnumerable<ArticleMemento> History => _memento.ToEnumerable();

        public ArticleMemento GetState()
        {
            return _memento;
        }

        public void SetState(ArticleMemento memento)
        {
            _memento = memento;
        }
    }

    public class RepositoryLastArticleCaretaker : IArticleCaretaker
    {
        private readonly IArticleMementoRepository mementoRepository;

        public RepositoryLastArticleCaretaker(IArticleMementoRepository mementoRepository)
        {
            this.mementoRepository = mementoRepository;
        }

        public IEnumerable<ArticleMemento> History => mementoRepository.GetAll();

        public ArticleMemento GetState()
        {
            return mementoRepository.GetLast();
        }

        public void SetState(ArticleMemento memento)
        {
            mementoRepository.Add(memento); 
        }
    }

    public interface IArticleMementoRepository
    {
        void Add(ArticleMemento memento);
        ArticleMemento GetLast();
        IEnumerable<ArticleMemento> GetAll();
    }

    public class DbArticleMementoRepository : IArticleMementoRepository
    {
        public void Add(ArticleMemento memento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArticleMemento> GetAll()
        {
            throw new NotImplementedException();
        }

        public ArticleMemento GetLast()
        {
            throw new NotImplementedException();
        }
    }

    // Concrete Caretaker B
    public class StackArticleCaretaker : IArticleCaretaker
    {
        private Stack<ArticleMemento> _mementos = new Stack<ArticleMemento>();

        public IEnumerable<ArticleMemento> History => _mementos;

        public ArticleMemento GetState() => _mementos.Pop();
        public void SetState(ArticleMemento memento) => _mementos.Push(memento);
    }


    public interface IRedo
    {
        ArticleMemento GetRedoState();
    }


    public class TwoWayArticleCaretaker : IArticleCaretaker, IRedo
    {
        public IEnumerable<ArticleMemento> History => _undo.History;

        private IArticleCaretaker _undo = new StackArticleCaretaker();
        private IArticleCaretaker _redo = new StackArticleCaretaker();


        // Undo
        public ArticleMemento GetState()
        {
            ArticleMemento articleMemento = _undo.GetState();
            _redo.SetState(articleMemento);

            return articleMemento;
        }

        public void SetState(ArticleMemento memento)
        {
            throw new NotImplementedException();
        }

        public ArticleMemento GetRedoState()
        {
            throw new NotImplementedException();
        }
    }
}
