using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationQuadratureSchemeDefinitionVectorKey : vtkInformationKey
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationQuadratureSchemeDefinitionVectorKey";

		public new static readonly string MRClassNameKey;

		static vtkInformationQuadratureSchemeDefinitionVectorKey()
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.MRClassNameKey = "class vtkInformationQuadratureSchemeDefinitionVectorKey";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationQuadratureSchemeDefinitionVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationQuadratureSchemeDefinitionVectorKey"));
		}

		public vtkInformationQuadratureSchemeDefinitionVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

		public void Append(vtkInformation info, vtkQuadratureSchemeDefinition value)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Clear_02(HandleRef pThis, HandleRef info);

		public void Clear(vtkInformation info)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Clear_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_DeepCopy_03(HandleRef pThis, HandleRef from, HandleRef to);

		public override void DeepCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_DeepCopy_03(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_Get_04(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkQuadratureSchemeDefinition Get(vtkInformation info, int idx)
		{
			vtkQuadratureSchemeDefinition vtkQuadratureSchemeDefinition = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Get_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_Length_07(HandleRef pThis, HandleRef info);

		public int Length(vtkInformation info)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Length_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationQuadratureSchemeDefinitionVectorKey NewInstance()
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Resize_09(HandleRef pThis, HandleRef info, int n);

		public void Resize(vtkInformation info, int n)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Resize_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_RestoreState_10(HandleRef pThis, HandleRef info, HandleRef element);

		public int RestoreState(vtkInformation info, vtkXMLDataElement element)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_RestoreState_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationQuadratureSchemeDefinitionVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey vtkInformationQuadratureSchemeDefinitionVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_SaveState_12(HandleRef pThis, HandleRef info, HandleRef element);

		public int SaveState(vtkInformation info, vtkXMLDataElement element)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_SaveState_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Set_13(HandleRef pThis, HandleRef info, HandleRef value, int i);

		public void Set(vtkInformation info, vtkQuadratureSchemeDefinition value, int i)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Set_13(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_ShallowCopy_14(HandleRef pThis, HandleRef from, HandleRef to);

		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_ShallowCopy_14(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_Size_15(HandleRef pThis, HandleRef info);

		public int Size(vtkInformation info)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Size_15(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}
	}
}
