using UnityEngine;
using System.Collections;

public class TestAdapter : UI.RecyclerView<TestAdapter.Holder>.Adapter {

    public override int GetItemCount()
    {
        throw new System.NotImplementedException();
    }

    public override void OnBindViewHolder(Holder holder, int i)
    {
        throw new System.NotImplementedException();
    }

    public override GameObject OnCreateViewHolder()
    {
        throw new System.NotImplementedException();
    }

    public class Holder : ViewHolder
    {
        public Holder(GameObject itemView) : base(itemView)
        {
        }
    }
}


