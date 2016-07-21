using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOverrideInformation : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverrideInformation";

		public new static readonly string MRClassNameKey;

		static vtkOverrideInformation()
		{
			vtkOverrideInformation.MRClassNameKey = "class vtkOverrideInformation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverrideInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverrideInformation"));
		}

		public vtkOverrideInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOverrideInformation New()
		{
			vtkOverrideInformation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOverrideInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOverrideInformation.vtkOverrideInformation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformation_GetClassOverrideName_01(HandleRef pThis);

		public string GetClassOverrideName()
		{
			return Marshal.PtrToStringAnsi(vtkOverrideInformation.vtkOverrideInformation_GetClassOverrideName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformation_GetClassOverrideWithName_02(HandleRef pThis);

		public string GetClassOverrideWithName()
		{
			return Marshal.PtrToStringAnsi(vtkOverrideInformation.vtkOverrideInformation_GetClassOverrideWithName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformation_GetDescription_03(HandleRef pThis);

		public string GetDescription()
		{
			return Marshal.PtrToStringAnsi(vtkOverrideInformation.vtkOverrideInformation_GetDescription_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformation_GetObjectFactory_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObjectFactory GetObjectFactory()
		{
			vtkObjectFactory vtkObjectFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_GetObjectFactory_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkOverrideInformation_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOverrideInformation.vtkOverrideInformation_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkOverrideInformation_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOverrideInformation.vtkOverrideInformation_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOverrideInformation NewInstance()
		{
			vtkOverrideInformation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOverrideInformation SafeDownCast(vtkObjectBase o)
		{
			vtkOverrideInformation vtkOverrideInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformation.vtkOverrideInformation_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverrideInformation = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverrideInformation.Register(null);
				}
			}
			return vtkOverrideInformation;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOverrideInformation_SetClassOverrideName_10(HandleRef pThis, string _arg);

		public virtual void SetClassOverrideName(string _arg)
		{
			vtkOverrideInformation.vtkOverrideInformation_SetClassOverrideName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOverrideInformation_SetClassOverrideWithName_11(HandleRef pThis, string _arg);

		public virtual void SetClassOverrideWithName(string _arg)
		{
			vtkOverrideInformation.vtkOverrideInformation_SetClassOverrideWithName_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOverrideInformation_SetDescription_12(HandleRef pThis, string _arg);

		public virtual void SetDescription(string _arg)
		{
			vtkOverrideInformation.vtkOverrideInformation_SetDescription_12(base.GetCppThis(), _arg);
		}
	}
}
