﻿#error TechTalk.SpecFlow.Generator.Interfaces.TestGenerationError
#error mscorlib
#error Server stack trace: 
#error    at System.Reflection.CustomAttribute._CreateCaObject(RuntimeModule pModule, IRuntimeMethodInfo pCtor, Byte** ppBlob, Byte* pEndBlob, Int32* pcNamedArgs)
#error    at System.Reflection.CustomAttribute.CreateCaObject(RuntimeModule module, IRuntimeMethodInfo ctor, IntPtr& blob, IntPtr blobEnd, Int32& namedArgs)
#error    at System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeModule decoratedModule, Int32 decoratedMetadataToken, Int32 pcaCount, RuntimeType attributeFilterType, Boolean mustBeInheritable, IList derivedAttributes, Boolean isDecoratedTargetSecurityTransparent)
#error    at System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeAssembly assembly, RuntimeType caType)
#error    at System.Reflection.RuntimeAssembly.GetCustomAttributes(Type attributeType, Boolean inherit)
#error    at System.Attribute.GetCustomAttributes(Assembly element, Type attributeType, Boolean inherit)
#error    at System.Attribute.GetCustomAttribute(Assembly element, Type attributeType, Boolean inherit)
#error    at TechTalk.SpecFlow.Generator.Plugins.GeneratorPluginLoader.LoadPlugin(PluginDescriptor pluginDescriptor)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugin(PluginDescriptor pluginDescriptor, IGeneratorPluginLoader pluginLoader, GeneratorPluginEvents generatorPluginEvents)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugins(ObjectContainer container, IGeneratorConfigurationProvider configurationProvider, SpecFlowConfigurationHolder configurationHolder, GeneratorPluginEvents generatorPluginEvents, SpecFlowProjectConfiguration specFlowConfiguration)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink._PrivateProcessMessage(IntPtr md, Object[] args, Object server, Object[]& outArgs)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink.SyncProcessMessage(IMessage msg)
#error Exception rethrown at [0]: 
#error    at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
#error    at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type)
#error    at TechTalk.SpecFlow.Generator.Interfaces.ITestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.RemoteAppDomainTestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.GeneratorServices.CreateTestGenerator()
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.GenerateCode(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.Generate(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, CodeDomHelper codeDomHelper, ProjectSettings projectSettings)