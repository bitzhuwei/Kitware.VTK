using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkObjectFactory : vtkObject
	{
		public delegate IntPtr CreateFunction();

		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectFactory";

		public new static readonly string MRClassNameKey;

		static vtkObjectFactory()
		{
			vtkObjectFactory.MRClassNameKey = "class vtkObjectFactory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectFactory"));
		}

		public vtkObjectFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_CreateAllInstance_01(string vtkclassname, HandleRef retList);

		public static void CreateAllInstance(string vtkclassname, vtkCollection retList)
		{
			vtkObjectFactory.vtkObjectFactory_CreateAllInstance_01(vtkclassname, (retList == null) ? default(HandleRef) : retList.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_CreateInstance_02(string vtkclassname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObject CreateInstance(string vtkclassname)
		{
			vtkObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_CreateInstance_02(vtkclassname, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_Disable_03(HandleRef pThis, string className);

		public virtual void Disable(string className)
		{
			vtkObjectFactory.vtkObjectFactory_Disable_03(base.GetCppThis(), className);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_GetClassOverrideName_04(HandleRef pThis, int index);

		public virtual string GetClassOverrideName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetClassOverrideName_04(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_GetClassOverrideWithName_05(HandleRef pThis, int index);

		public virtual string GetClassOverrideWithName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetClassOverrideWithName_05(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_GetDescription_06(HandleRef pThis);

		public virtual string GetDescription()
		{
			return Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetDescription_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_GetEnableFlag_07(HandleRef pThis, int index);

		public virtual int GetEnableFlag(int index)
		{
			return vtkObjectFactory.vtkObjectFactory_GetEnableFlag_07(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_GetEnableFlag_08(HandleRef pThis, string className, string subclassName);

		public virtual int GetEnableFlag(string className, string subclassName)
		{
			return vtkObjectFactory.vtkObjectFactory_GetEnableFlag_08(base.GetCppThis(), className, subclassName);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_GetLibraryPath_09(HandleRef pThis);

		public virtual string GetLibraryPath()
		{
			return Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetLibraryPath_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_GetNumberOfOverrides_10(HandleRef pThis);

		public virtual int GetNumberOfOverrides()
		{
			return vtkObjectFactory.vtkObjectFactory_GetNumberOfOverrides_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_GetOverrideDescription_11(HandleRef pThis, int index);

		public virtual string GetOverrideDescription(int index)
		{
			return Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetOverrideDescription_11(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_GetOverrideInformation_12(string name, HandleRef arg1);

		public static void GetOverrideInformation(string name, vtkOverrideInformationCollection arg1)
		{
			vtkObjectFactory.vtkObjectFactory_GetOverrideInformation_12(name, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_GetRegisteredFactories_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObjectFactoryCollection GetRegisteredFactories()
		{
			vtkObjectFactoryCollection vtkObjectFactoryCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_GetRegisteredFactories_13(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactoryCollection = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactoryCollection.Register(null);
				}
			}
			return vtkObjectFactoryCollection;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_GetVTKSourceVersion_14(HandleRef pThis);

		public virtual string GetVTKSourceVersion()
		{
			return Marshal.PtrToStringAnsi(vtkObjectFactory.vtkObjectFactory_GetVTKSourceVersion_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_HasOverride_15(HandleRef pThis, string className);

		public virtual int HasOverride(string className)
		{
			return vtkObjectFactory.vtkObjectFactory_HasOverride_15(base.GetCppThis(), className);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_HasOverride_16(HandleRef pThis, string className, string subclassName);

		public virtual int HasOverride(string className, string subclassName)
		{
			return vtkObjectFactory.vtkObjectFactory_HasOverride_16(base.GetCppThis(), className, subclassName);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_HasOverrideAny_17(string className);

		public static int HasOverrideAny(string className)
		{
			return vtkObjectFactory.vtkObjectFactory_HasOverrideAny_17(className);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkObjectFactory.vtkObjectFactory_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectFactory_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkObjectFactory.vtkObjectFactory_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkObjectFactory NewInstance()
		{
			vtkObjectFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_ReHash_21();

		public static void ReHash()
		{
			vtkObjectFactory.vtkObjectFactory_ReHash_21();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_RegisterFactory_22(HandleRef arg0);

		public static void RegisterFactory(vtkObjectFactory arg0)
		{
			vtkObjectFactory.vtkObjectFactory_RegisterFactory_22((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectFactory_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkObjectFactory SafeDownCast(vtkObjectBase o)
		{
			vtkObjectFactory vtkObjectFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectFactory.vtkObjectFactory_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactory = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactory.Register(null);
				}
			}
			return vtkObjectFactory;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_SetAllEnableFlags_24(int flag, string className);

		public static void SetAllEnableFlags(int flag, string className)
		{
			vtkObjectFactory.vtkObjectFactory_SetAllEnableFlags_24(flag, className);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_SetAllEnableFlags_25(int flag, string className, string subclassName);

		public static void SetAllEnableFlags(int flag, string className, string subclassName)
		{
			vtkObjectFactory.vtkObjectFactory_SetAllEnableFlags_25(flag, className, subclassName);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_SetEnableFlag_26(HandleRef pThis, int flag, string className, string subclassName);

		public virtual void SetEnableFlag(int flag, string className, string subclassName)
		{
			vtkObjectFactory.vtkObjectFactory_SetEnableFlag_26(base.GetCppThis(), flag, className, subclassName);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_UnRegisterAllFactories_27();

		public static void UnRegisterAllFactories()
		{
			vtkObjectFactory.vtkObjectFactory_UnRegisterAllFactories_27();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectFactory_UnRegisterFactory_28(HandleRef arg0);

		public static void UnRegisterFactory(vtkObjectFactory arg0)
		{
			vtkObjectFactory.vtkObjectFactory_UnRegisterFactory_28((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
