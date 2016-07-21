using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadratureSchemeDefinition : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadratureSchemeDefinition";

		public new static readonly string MRClassNameKey;

		static vtkQuadratureSchemeDefinition()
		{
			vtkQuadratureSchemeDefinition.MRClassNameKey = "class vtkQuadratureSchemeDefinition";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadratureSchemeDefinition.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadratureSchemeDefinition"));
		}

		public vtkQuadratureSchemeDefinition(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadratureSchemeDefinition New()
		{
			vtkQuadratureSchemeDefinition result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadratureSchemeDefinition() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkQuadratureSchemeDefinition_Clear_01(HandleRef pThis);

		public void Clear()
		{
			vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_Clear_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_DICTIONARY_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationQuadratureSchemeDefinitionVectorKey DICTIONARY()
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey vtkInformationQuadratureSchemeDefinitionVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_DICTIONARY_02(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationQuadratureSchemeDefinitionVectorKey = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationQuadratureSchemeDefinitionVectorKey.Register(null);
				}
			}
			return vtkInformationQuadratureSchemeDefinitionVectorKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_DeepCopy_03(HandleRef pThis, HandleRef other);

		public int DeepCopy(vtkQuadratureSchemeDefinition other)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_DeepCopy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_GetCellType_04(HandleRef pThis);

		public int GetCellType()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetCellType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_GetNumberOfNodes_05(HandleRef pThis);

		public int GetNumberOfNodes()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetNumberOfNodes_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_GetNumberOfQuadraturePoints_06(HandleRef pThis);

		public int GetNumberOfQuadraturePoints()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetNumberOfQuadraturePoints_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_GetQuadratureKey_07(HandleRef pThis);

		public int GetQuadratureKey()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetQuadratureKey_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_GetQuadratureWeights_08(HandleRef pThis);

		public IntPtr GetQuadratureWeights()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetQuadratureWeights_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_09(HandleRef pThis);

		public IntPtr GetShapeFunctionWeights()
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_10(HandleRef pThis, int quadraturePointId);

		public IntPtr GetShapeFunctionWeights(int quadraturePointId)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_GetShapeFunctionWeights_10(base.GetCppThis(), quadraturePointId);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkQuadratureSchemeDefinition_Initialize_11(HandleRef pThis, int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights);

		public void Initialize(int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights)
		{
			vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_Initialize_11(base.GetCppThis(), cellType, numberOfNodes, numberOfQuadraturePoints, shapeFunctionWeights);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkQuadratureSchemeDefinition_Initialize_12(HandleRef pThis, int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights, IntPtr quadratureWeights);

		public void Initialize(int cellType, int numberOfNodes, int numberOfQuadraturePoints, IntPtr shapeFunctionWeights, IntPtr quadratureWeights)
		{
			vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_Initialize_12(base.GetCppThis(), cellType, numberOfNodes, numberOfQuadraturePoints, shapeFunctionWeights, quadratureWeights);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadratureSchemeDefinition NewInstance()
		{
			vtkQuadratureSchemeDefinition result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_QUADRATURE_OFFSET_ARRAY_NAME_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringKey QUADRATURE_OFFSET_ARRAY_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_QUADRATURE_OFFSET_ARRAY_NAME_17(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_RestoreState_18(HandleRef pThis, HandleRef e);

		public int RestoreState(vtkXMLDataElement e)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_RestoreState_18(base.GetCppThis(), (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadratureSchemeDefinition_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadratureSchemeDefinition SafeDownCast(vtkObjectBase o)
		{
			vtkQuadratureSchemeDefinition vtkQuadratureSchemeDefinition = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadratureSchemeDefinition = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadratureSchemeDefinition.Register(null);
				}
			}
			return vtkQuadratureSchemeDefinition;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadratureSchemeDefinition_SaveState_20(HandleRef pThis, HandleRef e);

		public int SaveState(vtkXMLDataElement e)
		{
			return vtkQuadratureSchemeDefinition.vtkQuadratureSchemeDefinition_SaveState_20(base.GetCppThis(), (e == null) ? default(HandleRef) : e.GetCppThis());
		}
	}
}
