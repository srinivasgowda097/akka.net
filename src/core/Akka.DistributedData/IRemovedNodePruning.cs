﻿using Akka.Cluster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.DistributedData
{
    public interface IRemovedNodePruning<T> : IReplicatedData<T> where T : IReplicatedData
    {
        bool NeedPruningFrom(UniqueAddress removedNode);

        T Prune(UniqueAddress removedNode, UniqueAddress collapseInto);

        T PruningCleanup(UniqueAddress removedNode);
    }

    public interface IRemovedNodePruning : IRemovedNodePruning<IReplicatedData>
    {

    }
}