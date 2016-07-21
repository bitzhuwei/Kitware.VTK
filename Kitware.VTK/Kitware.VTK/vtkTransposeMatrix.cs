using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransposeMatrix : vtkArrayDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransposeMatrix";

		public new static readonly string MRClassNameKey;

		static vtkTransposeMatrix()
		{
			vtkTransposeMatrix.MRClassNameKey = "class vtkTransposeMatrix";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransposeMatrix.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransposeMatrix"));
		}

		public vtkTransposeMatrix(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransposeMatrix_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransposeMatrix New()
		{
			vtkTransposeMatrix result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransposeMatrix.vtkTransposeMatrix_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransposeMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransposeMatrix() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransposeMatrix.vtkTransposeMatrix_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTransposeMatrix_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransposeMatrix.vtkTransposeMatrix_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTransposeMatrix_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransposeMatrix.vtkTransposeMatrix_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransposeMatrix_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransposeMatrix NewInstance()
		{
			vtkTransposeMatrix result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransposeMatrix.vtkTransposeMatrix_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransposeMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransposeMatrix_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransposeMatrix SafeDownCast(vtkObjectBase o)
		{
			vtkTransposeMatrix vtkTransposeMatrix = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransposeMatrix.vtkTransposeMatrix_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransposeMatrix = (vtkTransposeMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransposeMatrix.Register(null);
				}
			}
			return vtkTransposeMatrix;
		}
	}
}
