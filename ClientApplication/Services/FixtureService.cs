using ClientApplication.Services.HttpClientService;
using ClientApplication.Models;
using System.Net;

namespace ClientApplication.Services.FixtureService;

public class FixtureService{
    public static async Task<Fixtures> getFixtures(){
        var fixtures = await HttpClientService.HttpClientService.GetAsync<Fixtures>("Fixture");
        if (fixtures is null) return new Fixtures();
        return fixtures;
    }
    public static async Task<Fixture?> createFixture(Fixture fixture)
    {
        return await HttpClientService.HttpClientService.PostAsync<Fixture>("Fixture", fixture);
    }
    public static async Task<HttpStatusCode> updateFixture(Fixture fixture){
        return await HttpClientService.HttpClientService.PutAsync<Fixture>($"Fixture/{fixture.Id}", fixture);
        
    }
    public static async Task<HttpStatusCode> deleteFixture(int id){
        return await HttpClientService.HttpClientService.DeleteAsync($"Fixture/{id}");
    }

}
