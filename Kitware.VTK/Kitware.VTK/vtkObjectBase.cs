using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkObjectBase : WrappedObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectBase";

		public new static readonly string MRClassNameKey;

		static vtkObjectBase()
		{
			vtkObjectBase.MRClassNameKey = "class vtkObjectBase";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectBase"));
		}

		public vtkObjectBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectBase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObjectBase New()
		{
			vtkObjectBase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObjectBase.vtkObjectBase_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkObjectBase() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkObjectBase.vtkObjectBase_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectBase_Register_10(HandleRef pThis, HandleRef o);

		public virtual void Register(vtkObjectBase o)
		{
			vtkObjectBase.vtkObjectBase_Register_10(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectBase_UnRegister_12(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkObjectBase.vtkObjectBase_UnRegister_12(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectBase_FastDelete_02(HandleRef pThis);

		public virtual void FastDelete()
		{
			vtkObjectBase.vtkObjectBase_FastDelete_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectBase_GetClassName_03(HandleRef pThis);

		public string GetClassName()
		{
			return Marshal.PtrToStringAnsi(vtkObjectBase.vtkObjectBase_GetClassName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectBase_GetClassNameA_04(HandleRef pThis);

		public string GetClassNameA()
		{
			return Marshal.PtrToStringAnsi(vtkObjectBase.vtkObjectBase_GetClassNameA_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectBase_GetClassNameW_05(HandleRef pThis);

		public string GetClassNameW()
		{
			return Marshal.PtrToStringAnsi(vtkObjectBase.vtkObjectBase_GetClassNameW_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectBase_GetReferenceCount_06(HandleRef pThis);

		public int GetReferenceCount()
		{
			return vtkObjectBase.vtkObjectBase_GetReferenceCount_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectBase_IsA_07(HandleRef pThis, string name);

		public virtual int IsA(string name)
		{
			return vtkObjectBase.vtkObjectBase_IsA_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObjectBase_IsTypeOf_08(string name);

		public static int IsTypeOf(string name)
		{
			return vtkObjectBase.vtkObjectBase_IsTypeOf_08(name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectBase_SetReferenceCount_11(HandleRef pThis, int arg0);

		public void SetReferenceCount(int arg0)
		{
			vtkObjectBase.vtkObjectBase_SetReferenceCount_11(base.GetCppThis(), arg0);
		}
	}
}
