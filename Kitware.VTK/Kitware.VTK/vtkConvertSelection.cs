using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConvertSelection : vtkSelectionAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertSelection";

		public new static readonly string MRClassNameKey;

		static vtkConvertSelection()
		{
			vtkConvertSelection.MRClassNameKey = "class vtkConvertSelection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertSelection"));
		}

		public vtkConvertSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConvertSelection New()
		{
			vtkConvertSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConvertSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConvertSelection.vtkConvertSelection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_AddArrayName_01(HandleRef pThis, string arg0);

		public void AddArrayName(string arg0)
		{
			vtkConvertSelection.vtkConvertSelection_AddArrayName_01(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_ClearArrayNames_02(HandleRef pThis);

		public void ClearArrayNames()
		{
			vtkConvertSelection.vtkConvertSelection_ClearArrayNames_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_GetArrayName_03(HandleRef pThis);

		public virtual string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkConvertSelection.vtkConvertSelection_GetArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_GetArrayNames_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_GetArrayNames_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConvertSelection_GetInputFieldType_05(HandleRef pThis);

		public virtual int GetInputFieldType()
		{
			return vtkConvertSelection.vtkConvertSelection_GetInputFieldType_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkConvertSelection_GetMatchAnyValues_06(HandleRef pThis);

		public virtual bool GetMatchAnyValues()
		{
			return vtkConvertSelection.vtkConvertSelection_GetMatchAnyValues_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConvertSelection_GetOutputType_07(HandleRef pThis);

		public virtual int GetOutputType()
		{
			return vtkConvertSelection.vtkConvertSelection_GetOutputType_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_GetSelectedCells_08(HandleRef input, HandleRef data, HandleRef indices);

		public static void GetSelectedCells(vtkSelection input, vtkDataSet data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedCells_08((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_GetSelectedEdges_09(HandleRef input, HandleRef data, HandleRef indices);

		public static void GetSelectedEdges(vtkSelection input, vtkGraph data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedEdges_09((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_GetSelectedItems_10(HandleRef input, HandleRef data, int fieldType, HandleRef indices);

		public static void GetSelectedItems(vtkSelection input, vtkDataObject data, int fieldType, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedItems_10((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), fieldType, (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_GetSelectedPoints_11(HandleRef input, HandleRef data, HandleRef indices);

		public static void GetSelectedPoints(vtkSelection input, vtkDataSet data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedPoints_11((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_GetSelectedRows_12(HandleRef input, HandleRef data, HandleRef indices);

		public static void GetSelectedRows(vtkSelection input, vtkTable data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedRows_12((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_GetSelectedVertices_13(HandleRef input, HandleRef data, HandleRef indices);

		public static void GetSelectedVertices(vtkSelection input, vtkGraph data, vtkIdTypeArray indices)
		{
			vtkConvertSelection.vtkConvertSelection_GetSelectedVertices_13((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (indices == null) ? default(HandleRef) : indices.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConvertSelection_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConvertSelection.vtkConvertSelection_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkConvertSelection_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConvertSelection.vtkConvertSelection_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_MatchAnyValuesOff_16(HandleRef pThis);

		public virtual void MatchAnyValuesOff()
		{
			vtkConvertSelection.vtkConvertSelection_MatchAnyValuesOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_MatchAnyValuesOn_17(HandleRef pThis);

		public virtual void MatchAnyValuesOn()
		{
			vtkConvertSelection.vtkConvertSelection_MatchAnyValuesOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConvertSelection NewInstance()
		{
			vtkConvertSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConvertSelection SafeDownCast(vtkObjectBase o)
		{
			vtkConvertSelection vtkConvertSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertSelection = (vtkConvertSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertSelection.Register(null);
				}
			}
			return vtkConvertSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_SetArrayName_21(HandleRef pThis, string arg0);

		public virtual void SetArrayName(string arg0)
		{
			vtkConvertSelection.vtkConvertSelection_SetArrayName_21(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_SetArrayNames_22(HandleRef pThis, HandleRef arg0);

		public virtual void SetArrayNames(vtkStringArray arg0)
		{
			vtkConvertSelection.vtkConvertSelection_SetArrayNames_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_SetDataObjectConnection_23(HandleRef pThis, HandleRef arg0);

		public void SetDataObjectConnection(vtkAlgorithmOutput arg0)
		{
			vtkConvertSelection.vtkConvertSelection_SetDataObjectConnection_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_SetInputFieldType_24(HandleRef pThis, int _arg);

		public virtual void SetInputFieldType(int _arg)
		{
			vtkConvertSelection.vtkConvertSelection_SetInputFieldType_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_SetMatchAnyValues_25(HandleRef pThis, byte _arg);

		public virtual void SetMatchAnyValues(bool _arg)
		{
			vtkConvertSelection.vtkConvertSelection_SetMatchAnyValues_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkConvertSelection_SetOutputType_26(HandleRef pThis, int _arg);

		public virtual void SetOutputType(int _arg)
		{
			vtkConvertSelection.vtkConvertSelection_SetOutputType_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_ToGlobalIdSelection_27(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkSelection ToGlobalIdSelection(vtkSelection input, vtkDataObject data)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToGlobalIdSelection_27((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_ToIndexSelection_28(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkSelection ToIndexSelection(vtkSelection input, vtkDataObject data)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToIndexSelection_28((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_ToPedigreeIdSelection_29(HandleRef input, HandleRef data, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkSelection ToPedigreeIdSelection(vtkSelection input, vtkDataObject data)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToPedigreeIdSelection_29((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_ToSelectionType_30(HandleRef input, HandleRef data, int type, HandleRef arrayNames, int inputFieldType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkSelection ToSelectionType(vtkSelection input, vtkDataObject data, int type, vtkStringArray arrayNames, int inputFieldType)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToSelectionType_30((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), type, (arrayNames == null) ? default(HandleRef) : arrayNames.GetCppThis(), inputFieldType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_ToValueSelection_31(HandleRef input, HandleRef data, string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkSelection ToValueSelection(vtkSelection input, vtkDataObject data, string arrayName)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToValueSelection_31((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), arrayName, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelection_ToValueSelection_32(HandleRef input, HandleRef data, HandleRef arrayNames, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkSelection ToValueSelection(vtkSelection input, vtkDataObject data, vtkStringArray arrayNames)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelection.vtkConvertSelection_ToValueSelection_32((input == null) ? default(HandleRef) : input.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (arrayNames == null) ? default(HandleRef) : arrayNames.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}
	}
}
