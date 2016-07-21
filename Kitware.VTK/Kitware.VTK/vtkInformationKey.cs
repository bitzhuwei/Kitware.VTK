using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkInformationKey : vtkObjectBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationKey()
		{
			vtkInformationKey.MRClassNameKey = "class vtkInformationKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationKey"));
		}

		public vtkInformationKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKey_Register_09(HandleRef pThis, HandleRef arg0);

		public override void Register(vtkObjectBase arg0)
		{
			vtkInformationKey.vtkInformationKey_Register_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKey_UnRegister_14(HandleRef pThis, HandleRef arg0);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkInformationKey.vtkInformationKey_UnRegister_14(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKey_DeepCopy_01(HandleRef pThis, HandleRef from, HandleRef to);

		public virtual void DeepCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationKey.vtkInformationKey_DeepCopy_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationKey_GetLocation_02(HandleRef pThis);

		public string GetLocation()
		{
			return Marshal.PtrToStringAnsi(vtkInformationKey.vtkInformationKey_GetLocation_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationKey_GetName_03(HandleRef pThis);

		public string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkInformationKey.vtkInformationKey_GetName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationKey_Has_04(HandleRef pThis, HandleRef info);

		public virtual int Has(vtkInformation info)
		{
			return vtkInformationKey.vtkInformationKey_Has_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationKey_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationKey.vtkInformationKey_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationKey_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationKey.vtkInformationKey_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationKey NewInstance()
		{
			vtkInformationKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationKey.vtkInformationKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKey_Print_08(HandleRef pThis, HandleRef info);

		public void Print(vtkInformation info)
		{
			vtkInformationKey.vtkInformationKey_Print_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKey_Remove_10(HandleRef pThis, HandleRef info);

		public virtual void Remove(vtkInformation info)
		{
			vtkInformationKey.vtkInformationKey_Remove_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKey_Report_11(HandleRef pThis, HandleRef info, HandleRef collector);

		public virtual void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationKey.vtkInformationKey_Report_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationKey_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationKey.vtkInformationKey_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationKey_ShallowCopy_13(HandleRef pThis, HandleRef from, HandleRef to);

		public virtual void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationKey.vtkInformationKey_ShallowCopy_13(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}
	}
}
