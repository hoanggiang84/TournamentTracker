﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace UIForm
{
    public interface ITeamRequester
    {
        void TeamComplete(TeamModel model);
    }
}
