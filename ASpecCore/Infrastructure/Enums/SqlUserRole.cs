using System;

namespace ASpecCore.Infrastructure.Enums
{
    [Flags]
    public enum SqlUserRole
    {
        Unknown         = 0b_0000_0000,
        ReadWrite       = 0b_0000_0001,
        ReadOnly        = 0b_0000_0010,
        DesignTeam      = 0b_0000_0100,
        ConfirmElements = 0b_0000_1000,
        AlbumAdmin      = 0b_0001_0000,
        EndProdAdmin    = 0b_0010_0000,
        NetDeveloper    = 0b_0100_0000
    }
}
