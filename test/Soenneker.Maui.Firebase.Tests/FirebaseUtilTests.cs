using Soenneker.Maui.Firebase.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Maui.Firebase.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class FirebaseUtilTests : HostedUnitTest
{

    public FirebaseUtilTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
