using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDicer : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDicer";

		public new static readonly string MRClassNameKey;

		static vtkDicer()
		{
			vtkDicer.MRClassNameKey = "class vtkDicer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDicer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDicer"));
		}

		public vtkDicer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_FieldDataOff_01(HandleRef pThis);

		public virtual void FieldDataOff()
		{
			vtkDicer.vtkDicer_FieldDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_FieldDataOn_02(HandleRef pThis);

		public virtual void FieldDataOn()
		{
			vtkDicer.vtkDicer_FieldDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetDiceMode_03(HandleRef pThis);

		public virtual int GetDiceMode()
		{
			return vtkDicer.vtkDicer_GetDiceMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetDiceModeMaxValue_04(HandleRef pThis);

		public virtual int GetDiceModeMaxValue()
		{
			return vtkDicer.vtkDicer_GetDiceModeMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetDiceModeMinValue_05(HandleRef pThis);

		public virtual int GetDiceModeMinValue()
		{
			return vtkDicer.vtkDicer_GetDiceModeMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetFieldData_06(HandleRef pThis);

		public virtual int GetFieldData()
		{
			return vtkDicer.vtkDicer_GetFieldData_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkDicer_GetMemoryLimit_07(HandleRef pThis);

		public virtual uint GetMemoryLimit()
		{
			return vtkDicer.vtkDicer_GetMemoryLimit_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkDicer_GetMemoryLimitMaxValue_08(HandleRef pThis);

		public virtual uint GetMemoryLimitMaxValue()
		{
			return vtkDicer.vtkDicer_GetMemoryLimitMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkDicer_GetMemoryLimitMinValue_09(HandleRef pThis);

		public virtual uint GetMemoryLimitMinValue()
		{
			return vtkDicer.vtkDicer_GetMemoryLimitMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetNumberOfActualPieces_10(HandleRef pThis);

		public virtual int GetNumberOfActualPieces()
		{
			return vtkDicer.vtkDicer_GetNumberOfActualPieces_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetNumberOfPieces_11(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkDicer.vtkDicer_GetNumberOfPieces_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetNumberOfPiecesMaxValue_12(HandleRef pThis);

		public virtual int GetNumberOfPiecesMaxValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPiecesMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetNumberOfPiecesMinValue_13(HandleRef pThis);

		public virtual int GetNumberOfPiecesMinValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPiecesMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetNumberOfPointsPerPiece_14(HandleRef pThis);

		public virtual int GetNumberOfPointsPerPiece()
		{
			return vtkDicer.vtkDicer_GetNumberOfPointsPerPiece_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetNumberOfPointsPerPieceMaxValue_15(HandleRef pThis);

		public virtual int GetNumberOfPointsPerPieceMaxValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPointsPerPieceMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_GetNumberOfPointsPerPieceMinValue_16(HandleRef pThis);

		public virtual int GetNumberOfPointsPerPieceMinValue()
		{
			return vtkDicer.vtkDicer_GetNumberOfPointsPerPieceMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDicer.vtkDicer_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDicer_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDicer.vtkDicer_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDicer_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDicer NewInstance()
		{
			vtkDicer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDicer.vtkDicer_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDicer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDicer_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDicer SafeDownCast(vtkObjectBase o)
		{
			vtkDicer vtkDicer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDicer.vtkDicer_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDicer = (vtkDicer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDicer.Register(null);
				}
			}
			return vtkDicer;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetDiceMode_21(HandleRef pThis, int _arg);

		public virtual void SetDiceMode(int _arg)
		{
			vtkDicer.vtkDicer_SetDiceMode_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetDiceModeToMemoryLimitPerPiece_22(HandleRef pThis);

		public void SetDiceModeToMemoryLimitPerPiece()
		{
			vtkDicer.vtkDicer_SetDiceModeToMemoryLimitPerPiece_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetDiceModeToNumberOfPointsPerPiece_23(HandleRef pThis);

		public void SetDiceModeToNumberOfPointsPerPiece()
		{
			vtkDicer.vtkDicer_SetDiceModeToNumberOfPointsPerPiece_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetDiceModeToSpecifiedNumberOfPieces_24(HandleRef pThis);

		public void SetDiceModeToSpecifiedNumberOfPieces()
		{
			vtkDicer.vtkDicer_SetDiceModeToSpecifiedNumberOfPieces_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetFieldData_25(HandleRef pThis, int _arg);

		public virtual void SetFieldData(int _arg)
		{
			vtkDicer.vtkDicer_SetFieldData_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetMemoryLimit_26(HandleRef pThis, uint _arg);

		public virtual void SetMemoryLimit(uint _arg)
		{
			vtkDicer.vtkDicer_SetMemoryLimit_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetNumberOfPieces_27(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkDicer.vtkDicer_SetNumberOfPieces_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDicer_SetNumberOfPointsPerPiece_28(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPointsPerPiece(int _arg)
		{
			vtkDicer.vtkDicer_SetNumberOfPointsPerPiece_28(base.GetCppThis(), _arg);
		}
	}
}
