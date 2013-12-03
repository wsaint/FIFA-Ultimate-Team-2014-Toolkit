﻿namespace UltimateTeam.Toolkit.Constants
{
    public enum FutErrorCode : ushort
    {
        ExpiredSession = 401,
        Conflict = 409,
        BadRequest = 460,
        PermissionDenied = 461,
        InternalServerError = 500,
        ServiceUnavailable = 503
    }
}
