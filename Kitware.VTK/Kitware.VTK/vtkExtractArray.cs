using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractArray : vtkArrayDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractArray";

		public new static readonly string MRClassNameKey;

		static vtkExtractArray()
		{
			vtkExtractArray.MRClassNameKey = "class vtkExtractArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractArray"));
		}

		public vtkExtractArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractArray New()
		{
			vtkExtractArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractArray.vtkExtractArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractArray.vtkExtractArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkExtractArray_GetIndex_01(HandleRef pThis);

		public virtual long GetIndex()
		{
			return vtkExtractArray.vtkExtractArray_GetIndex_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractArray_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractArray.vtkExtractArray_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractArray_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractArray.vtkExtractArray_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractArray_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractArray NewInstance()
		{
			vtkExtractArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractArray.vtkExtractArray_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractArray_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractArray SafeDownCast(vtkObjectBase o)
		{
			vtkExtractArray vtkExtractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractArray.vtkExtractArray_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractArray = (vtkExtractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractArray.Register(null);
				}
			}
			return vtkExtractArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractArray_SetIndex_07(HandleRef pThis, long _arg);

		public virtual void SetIndex(long _arg)
		{
			vtkExtractArray.vtkExtractArray_SetIndex_07(base.GetCppThis(), _arg);
		}
	}
}
