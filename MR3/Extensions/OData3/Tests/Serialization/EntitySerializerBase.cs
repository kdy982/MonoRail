using System;
using Castle.MonoRail.OData.Internal;
using Microsoft.Data.Edm;
using Microsoft.Data.OData;
using NUnit.Framework;

namespace Castle.MonoRail.Extension.OData3.Tests.Serialization
{
	public abstract class EntitySerializerBase : ODataTestCommon
	{
		protected EntitySerializer serializer;
		protected ODataMessageWriter writer;
		protected IEdmModel model;
		protected StubODataResponse response;

		[SetUp]
		public void Init()
		{
			var settings = CreateMessageWriterSettings(new Uri("http://testing/"), ODataFormat.JsonLight);
			model = Models.ModelWithAssociation.Build();
			response = new StubODataResponse();
			writer = new ODataMessageWriter(response, settings, model);
			serializer = new EntitySerializer(writer);
		}
	}

	[TestFixture]
	public class NonEntitySerializer_CollSupport_TestCase : NonEntitySerializerBase
	{
		[Test]
		public void aaaa()
		{
			// serializer.WriteCollection(elements, typ);
		}
	}

	[TestFixture]
	public class NonEntitySerializer_PropertySupport_TestCase : NonEntitySerializerBase
	{

	}

}