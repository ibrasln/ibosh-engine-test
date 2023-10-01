using System.Collections.Generic;
using UnityEngine;

namespace IboshEngine.ObjectPool
{
    public class ObjectPool<T>
    {
        private readonly GameObject _poolItemPref;
        private readonly Transform _poolHolder;

        private readonly int _poolStartSize;

        private readonly Stack<T> _pool;

        private int _poolSize;

        public ObjectPool(GameObject itemPref, Transform poolHolder, int startSize)
        {
            _poolItemPref = itemPref;
            _poolHolder = poolHolder;
            _poolStartSize = startSize;
            _poolSize = 0;
            _pool = new();

            Fill();
        }

        private void Fill()
        {
            if (_poolSize >= _poolStartSize) return;

            int step = _poolStartSize - _poolSize;
            for (int i = 0; i < step; i++)
            {
                SpawnNewItem();
            }
        }

        private void SpawnNewItem()
        {
            var item = Object.Instantiate(_poolItemPref, _poolHolder);
            Push(item);
        }

        public void Push(GameObject item)
        {
            _poolSize++;
            _pool.Push(item.GetComponent<T>());
            item.SetActive(false);
        }

        public T Pull()
        {
            if (_poolSize <= 0) SpawnNewItem();

            _poolSize--;
            T item = _pool.Pop();
            return item;
        }
    }
}
