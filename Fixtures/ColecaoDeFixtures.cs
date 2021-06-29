using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjetoDesafioUsandoXUnit.Fixtures
{
    [CollectionDefinition("Fixtures")]
    public class ColecaoDeFixtures : ICollectionFixture<FixtureDeTeste>
    {

    }
}
