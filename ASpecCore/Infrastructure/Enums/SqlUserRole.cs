using System;

namespace ASpecCore.Infrastructure.Enums
{
    [Flags]
    public enum SqlUserRole
    {
        Unknown         = 0,
        ReadWrite       = 1,
        ReadOnly        = 2,
        DesignTeam      = 4,
        ConfirmElements = 8,
        AlbumAdmin      = 16,
        EndProdAdmin    = 32,
        NetDeveloper    = 64
    }
}
