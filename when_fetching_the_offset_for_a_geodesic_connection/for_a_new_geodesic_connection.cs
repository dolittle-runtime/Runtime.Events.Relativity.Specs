﻿// Copyright (c) Dolittle. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Machine.Specifications;

namespace Dolittle.Runtime.Events.Relativity.Specs.when_fetching_the_offset_for_an_geodesic_connection
{
    [Subject(typeof(IGeodesics), nameof(IGeodesics.GetOffset))]
    public class for_a_new_geodesic_connection : given.a_geodesics
    {
        static IGeodesics geodesics;
        static ulong offset;
        Establish context = () => geodesics = get_geodesics();

        Because of = () => offset = geodesics.GetOffset(new EventHorizonKey(Guid.NewGuid(), Guid.NewGuid()));

        It should_return_0 = () => ((long)offset).ShouldEqual(0);
    }
}