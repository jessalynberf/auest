public interface IHasUrlBuilder2
{
    IHasUrlBuilder2 WithUrl(string url);
}

public interface IHasGetMethodBuilder2<TGetBuilder>
{
    TGetBuilder AddQueryParameter(string name, string value);
}

public interface IHasPostMethodBuilder2<TPostBuilder>
{
    TPostBuilder AddBodyParameter(string name, string value);
}
