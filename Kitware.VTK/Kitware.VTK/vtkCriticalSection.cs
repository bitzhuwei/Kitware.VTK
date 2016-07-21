using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCriticalSection : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCriticalSection";

		public new static readonly string MRClassNameKey;

		static vtkCriticalSection()
		{
			vtkCriticalSection.MRClassNameKey = "class vtkCriticalSection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCriticalSection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCriticalSection"));
		}

		public vtkCriticalSection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCriticalSection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCriticalSection New()
		{
			vtkCriticalSection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCriticalSection.vtkCriticalSection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCriticalSection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCriticalSection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCriticalSection.vtkCriticalSection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCriticalSection_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCriticalSection.vtkCriticalSection_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCriticalSection_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCriticalSection.vtkCriticalSection_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCriticalSection_Lock_03(HandleRef pThis);

		public void Lock()
		{
			vtkCriticalSection.vtkCriticalSection_Lock_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCriticalSection_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCriticalSection NewInstance()
		{
			vtkCriticalSection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCriticalSection.vtkCriticalSection_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCriticalSection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCriticalSection_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCriticalSection SafeDownCast(vtkObjectBase o)
		{
			vtkCriticalSection vtkCriticalSection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCriticalSection.vtkCriticalSection_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCriticalSection = (vtkCriticalSection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCriticalSection.Register(null);
				}
			}
			return vtkCriticalSection;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCriticalSection_Unlock_07(HandleRef pThis);

		public void Unlock()
		{
			vtkCriticalSection.vtkCriticalSection_Unlock_07(base.GetCppThis());
		}
	}
}
