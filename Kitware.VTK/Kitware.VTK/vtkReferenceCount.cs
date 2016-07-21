using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReferenceCount : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkReferenceCount";

		public new static readonly string MRClassNameKey;

		static vtkReferenceCount()
		{
			vtkReferenceCount.MRClassNameKey = "class vtkReferenceCount";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReferenceCount.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReferenceCount"));
		}

		public vtkReferenceCount(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkReferenceCount_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReferenceCount New()
		{
			vtkReferenceCount result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReferenceCount.vtkReferenceCount_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReferenceCount)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReferenceCount() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReferenceCount.vtkReferenceCount_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkReferenceCount_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReferenceCount.vtkReferenceCount_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkReferenceCount_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReferenceCount.vtkReferenceCount_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkReferenceCount_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReferenceCount NewInstance()
		{
			vtkReferenceCount result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReferenceCount.vtkReferenceCount_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReferenceCount)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkReferenceCount_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReferenceCount SafeDownCast(vtkObjectBase o)
		{
			vtkReferenceCount vtkReferenceCount = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReferenceCount.vtkReferenceCount_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReferenceCount = (vtkReferenceCount)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReferenceCount.Register(null);
				}
			}
			return vtkReferenceCount;
		}
	}
}
