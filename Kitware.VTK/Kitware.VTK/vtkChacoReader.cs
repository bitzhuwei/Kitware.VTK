using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkChacoReader : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkChacoReader";

		public new static readonly string MRClassNameKey;

		static vtkChacoReader()
		{
			vtkChacoReader.MRClassNameKey = "class vtkChacoReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChacoReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChacoReader"));
		}

		public vtkChacoReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChacoReader New()
		{
			vtkChacoReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChacoReader.vtkChacoReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkChacoReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkChacoReader.vtkChacoReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateEdgeWeightArraysOff_01(HandleRef pThis);

		public virtual void GenerateEdgeWeightArraysOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateEdgeWeightArraysOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateEdgeWeightArraysOn_02(HandleRef pThis);

		public virtual void GenerateEdgeWeightArraysOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateEdgeWeightArraysOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateGlobalElementIdArrayOff_03(HandleRef pThis);

		public virtual void GenerateGlobalElementIdArrayOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalElementIdArrayOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateGlobalElementIdArrayOn_04(HandleRef pThis);

		public virtual void GenerateGlobalElementIdArrayOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalElementIdArrayOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateGlobalNodeIdArrayOff_05(HandleRef pThis);

		public virtual void GenerateGlobalNodeIdArrayOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalNodeIdArrayOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateGlobalNodeIdArrayOn_06(HandleRef pThis);

		public virtual void GenerateGlobalNodeIdArrayOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalNodeIdArrayOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateVertexWeightArraysOff_07(HandleRef pThis);

		public virtual void GenerateVertexWeightArraysOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateVertexWeightArraysOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_GenerateVertexWeightArraysOn_08(HandleRef pThis);

		public virtual void GenerateVertexWeightArraysOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateVertexWeightArraysOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_GetBaseName_09(HandleRef pThis);

		public virtual string GetBaseName()
		{
			return Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetBaseName_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetDimensionality_10(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkChacoReader.vtkChacoReader_GetDimensionality_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_GetEdgeWeightArrayName_11(HandleRef pThis, int weight);

		public string GetEdgeWeightArrayName(int weight)
		{
			return Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetEdgeWeightArrayName_11(base.GetCppThis(), weight));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetGenerateEdgeWeightArrays_12(HandleRef pThis);

		public virtual int GetGenerateEdgeWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateEdgeWeightArrays_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetGenerateGlobalElementIdArray_13(HandleRef pThis);

		public virtual int GetGenerateGlobalElementIdArray()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateGlobalElementIdArray_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetGenerateGlobalNodeIdArray_14(HandleRef pThis);

		public virtual int GetGenerateGlobalNodeIdArray()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateGlobalNodeIdArray_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetGenerateVertexWeightArrays_15(HandleRef pThis);

		public virtual int GetGenerateVertexWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateVertexWeightArrays_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_GetGlobalElementIdArrayName_16();

		public static string GetGlobalElementIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetGlobalElementIdArrayName_16());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_GetGlobalNodeIdArrayName_17();

		public static string GetGlobalNodeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetGlobalNodeIdArrayName_17());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetNumberOfCellWeightArrays_18(HandleRef pThis);

		public virtual int GetNumberOfCellWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfCellWeightArrays_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetNumberOfEdgeWeights_19(HandleRef pThis);

		public virtual int GetNumberOfEdgeWeights()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfEdgeWeights_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkChacoReader_GetNumberOfEdges_20(HandleRef pThis);

		public virtual long GetNumberOfEdges()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfEdges_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetNumberOfPointWeightArrays_21(HandleRef pThis);

		public virtual int GetNumberOfPointWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfPointWeightArrays_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_GetNumberOfVertexWeights_22(HandleRef pThis);

		public virtual int GetNumberOfVertexWeights()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfVertexWeights_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkChacoReader_GetNumberOfVertices_23(HandleRef pThis);

		public virtual long GetNumberOfVertices()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfVertices_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_GetVertexWeightArrayName_24(HandleRef pThis, int weight);

		public string GetVertexWeightArrayName(int weight)
		{
			return Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetVertexWeightArrayName_24(base.GetCppThis(), weight));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChacoReader.vtkChacoReader_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkChacoReader_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChacoReader.vtkChacoReader_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChacoReader NewInstance()
		{
			vtkChacoReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChacoReader.vtkChacoReader_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkChacoReader_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChacoReader SafeDownCast(vtkObjectBase o)
		{
			vtkChacoReader vtkChacoReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChacoReader.vtkChacoReader_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChacoReader = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChacoReader.Register(null);
				}
			}
			return vtkChacoReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_SetBaseName_30(HandleRef pThis, string _arg);

		public virtual void SetBaseName(string _arg)
		{
			vtkChacoReader.vtkChacoReader_SetBaseName_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_SetGenerateEdgeWeightArrays_31(HandleRef pThis, int _arg);

		public virtual void SetGenerateEdgeWeightArrays(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateEdgeWeightArrays_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_SetGenerateGlobalElementIdArray_32(HandleRef pThis, int _arg);

		public virtual void SetGenerateGlobalElementIdArray(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateGlobalElementIdArray_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_SetGenerateGlobalNodeIdArray_33(HandleRef pThis, int _arg);

		public virtual void SetGenerateGlobalNodeIdArray(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateGlobalNodeIdArray_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkChacoReader_SetGenerateVertexWeightArrays_34(HandleRef pThis, int _arg);

		public virtual void SetGenerateVertexWeightArrays(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateVertexWeightArrays_34(base.GetCppThis(), _arg);
		}
	}
}
