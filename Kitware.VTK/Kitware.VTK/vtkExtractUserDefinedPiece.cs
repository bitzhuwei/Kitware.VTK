using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractUserDefinedPiece : vtkExtractUnstructuredGridPiece
	{
		public delegate int UserDefFunc(long arg0, IntPtr arg1, IntPtr arg2);

		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUserDefinedPiece";

		public new static readonly string MRClassNameKey;

		static vtkExtractUserDefinedPiece()
		{
			vtkExtractUserDefinedPiece.MRClassNameKey = "class vtkExtractUserDefinedPiece";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractUserDefinedPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUserDefinedPiece"));
		}

		public vtkExtractUserDefinedPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUserDefinedPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractUserDefinedPiece New()
		{
			vtkExtractUserDefinedPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractUserDefinedPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractUserDefinedPiece_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractUserDefinedPiece_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUserDefinedPiece_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractUserDefinedPiece NewInstance()
		{
			vtkExtractUserDefinedPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUserDefinedPiece_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractUserDefinedPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractUserDefinedPiece vtkExtractUserDefinedPiece = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractUserDefinedPiece = (vtkExtractUserDefinedPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractUserDefinedPiece.Register(null);
				}
			}
			return vtkExtractUserDefinedPiece;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractUserDefinedPiece_SetConstantData_06(HandleRef pThis, IntPtr data, int len);

		public void SetConstantData(IntPtr data, int len)
		{
			vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_SetConstantData_06(base.GetCppThis(), data, len);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractUserDefinedPiece_SetPieceFunction_07(HandleRef pThis, vtkExtractUserDefinedPiece.UserDefFunc func);

		public void SetPieceFunction(vtkExtractUserDefinedPiece.UserDefFunc func)
		{
			vtkExtractUserDefinedPiece.vtkExtractUserDefinedPiece_SetPieceFunction_07(base.GetCppThis(), func);
		}
	}
}
