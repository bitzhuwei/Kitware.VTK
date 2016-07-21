using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMatricizeArray : vtkArrayDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatricizeArray";

		public new static readonly string MRClassNameKey;

		static vtkMatricizeArray()
		{
			vtkMatricizeArray.MRClassNameKey = "class vtkMatricizeArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatricizeArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatricizeArray"));
		}

		public vtkMatricizeArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMatricizeArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatricizeArray New()
		{
			vtkMatricizeArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatricizeArray.vtkMatricizeArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatricizeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMatricizeArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMatricizeArray.vtkMatricizeArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkMatricizeArray_GetSliceDimension_01(HandleRef pThis);

		public virtual long GetSliceDimension()
		{
			return vtkMatricizeArray.vtkMatricizeArray_GetSliceDimension_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMatricizeArray_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMatricizeArray.vtkMatricizeArray_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMatricizeArray_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMatricizeArray.vtkMatricizeArray_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMatricizeArray_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMatricizeArray NewInstance()
		{
			vtkMatricizeArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatricizeArray.vtkMatricizeArray_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatricizeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMatricizeArray_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatricizeArray SafeDownCast(vtkObjectBase o)
		{
			vtkMatricizeArray vtkMatricizeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatricizeArray.vtkMatricizeArray_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatricizeArray = (vtkMatricizeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatricizeArray.Register(null);
				}
			}
			return vtkMatricizeArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMatricizeArray_SetSliceDimension_07(HandleRef pThis, long _arg);

		public virtual void SetSliceDimension(long _arg)
		{
			vtkMatricizeArray.vtkMatricizeArray_SetSliceDimension_07(base.GetCppThis(), _arg);
		}
	}
}
