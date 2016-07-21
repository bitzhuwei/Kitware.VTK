using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPieceRequestFilter : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPieceRequestFilter";

		public new static readonly string MRClassNameKey;

		static vtkPieceRequestFilter()
		{
			vtkPieceRequestFilter.MRClassNameKey = "class vtkPieceRequestFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPieceRequestFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPieceRequestFilter"));
		}

		public vtkPieceRequestFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceRequestFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPieceRequestFilter New()
		{
			vtkPieceRequestFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceRequestFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPieceRequestFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPieceRequestFilter.vtkPieceRequestFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_GetNumberOfPieces_01(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfPieces_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_GetNumberOfPiecesMaxValue_02(HandleRef pThis);

		public virtual int GetNumberOfPiecesMaxValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfPiecesMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_GetNumberOfPiecesMinValue_03(HandleRef pThis);

		public virtual int GetNumberOfPiecesMinValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetNumberOfPiecesMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceRequestFilter_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_GetOutput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceRequestFilter_GetOutput_05(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetOutput(int arg0)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_GetOutput_05(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_GetPiece_06(HandleRef pThis);

		public virtual int GetPiece()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetPiece_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_GetPieceMaxValue_07(HandleRef pThis);

		public virtual int GetPieceMaxValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetPieceMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_GetPieceMinValue_08(HandleRef pThis);

		public virtual int GetPieceMinValue()
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_GetPieceMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPieceRequestFilter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPieceRequestFilter.vtkPieceRequestFilter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceRequestFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPieceRequestFilter NewInstance()
		{
			vtkPieceRequestFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceRequestFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPieceRequestFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPieceRequestFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPieceRequestFilter vtkPieceRequestFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieceRequestFilter.vtkPieceRequestFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPieceRequestFilter = (vtkPieceRequestFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPieceRequestFilter.Register(null);
				}
			}
			return vtkPieceRequestFilter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceRequestFilter_SetInput_14(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkDataObject arg0)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetInput_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceRequestFilter_SetInput_15(HandleRef pThis, int arg0, HandleRef arg1);

		public void SetInput(int arg0, vtkDataObject arg1)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetInput_15(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceRequestFilter_SetNumberOfPieces_16(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetNumberOfPieces_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPieceRequestFilter_SetPiece_17(HandleRef pThis, int _arg);

		public virtual void SetPiece(int _arg)
		{
			vtkPieceRequestFilter.vtkPieceRequestFilter_SetPiece_17(base.GetCppThis(), _arg);
		}
	}
}
