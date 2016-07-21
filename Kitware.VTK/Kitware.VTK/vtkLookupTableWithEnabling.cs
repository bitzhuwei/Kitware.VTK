using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLookupTableWithEnabling : vtkLookupTable
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTableWithEnabling";

		public new static readonly string MRClassNameKey;

		static vtkLookupTableWithEnabling()
		{
			vtkLookupTableWithEnabling.MRClassNameKey = "class vtkLookupTableWithEnabling";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLookupTableWithEnabling.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTableWithEnabling"));
		}

		public vtkLookupTableWithEnabling(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableWithEnabling_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLookupTableWithEnabling New()
		{
			vtkLookupTableWithEnabling result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLookupTableWithEnabling() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTableWithEnabling_DisableColor_01(HandleRef pThis, byte r, byte g, byte b, IntPtr rd, IntPtr gd, IntPtr bd);

		public virtual void DisableColor(byte r, byte g, byte b, IntPtr rd, IntPtr gd, IntPtr bd)
		{
			vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_DisableColor_01(base.GetCppThis(), r, g, b, rd, gd, bd);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableWithEnabling_GetEnabledArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetEnabledArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_GetEnabledArray_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTableWithEnabling_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTableWithEnabling_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTableWithEnabling_MapScalarsThroughTable2_05(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement);

		public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
		{
			vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_MapScalarsThroughTable2_05(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableWithEnabling_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLookupTableWithEnabling NewInstance()
		{
			vtkLookupTableWithEnabling result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTableWithEnabling_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLookupTableWithEnabling SafeDownCast(vtkObjectBase o)
		{
			vtkLookupTableWithEnabling vtkLookupTableWithEnabling = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTableWithEnabling = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTableWithEnabling.Register(null);
				}
			}
			return vtkLookupTableWithEnabling;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTableWithEnabling_SetEnabledArray_09(HandleRef pThis, HandleRef enabledArray);

		public virtual void SetEnabledArray(vtkDataArray enabledArray)
		{
			vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_SetEnabledArray_09(base.GetCppThis(), (enabledArray == null) ? default(HandleRef) : enabledArray.GetCppThis());
		}
	}
}
