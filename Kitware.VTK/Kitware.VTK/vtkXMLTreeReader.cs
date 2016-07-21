using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLTreeReader : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLTreeReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLTreeReader()
		{
			vtkXMLTreeReader.MRClassNameKey = "class vtkXMLTreeReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLTreeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLTreeReader"));
		}

		public vtkXMLTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLTreeReader New()
		{
			vtkXMLTreeReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLTreeReader.vtkXMLTreeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLTreeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLTreeReader.vtkXMLTreeReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_GenerateEdgePedigreeIdsOff_01(HandleRef pThis);

		public virtual void GenerateEdgePedigreeIdsOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateEdgePedigreeIdsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_GenerateEdgePedigreeIdsOn_02(HandleRef pThis);

		public virtual void GenerateEdgePedigreeIdsOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateEdgePedigreeIdsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_GenerateVertexPedigreeIdsOff_03(HandleRef pThis);

		public virtual void GenerateVertexPedigreeIdsOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateVertexPedigreeIdsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_GenerateVertexPedigreeIdsOn_04(HandleRef pThis);

		public virtual void GenerateVertexPedigreeIdsOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_GenerateVertexPedigreeIdsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLTreeReader_GetEdgePedigreeIdArrayName_05(HandleRef pThis);

		public virtual string GetEdgePedigreeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetEdgePedigreeIdArrayName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLTreeReader_GetFileName_06(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetFileName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkXMLTreeReader_GetGenerateEdgePedigreeIds_07(HandleRef pThis);

		public virtual bool GetGenerateEdgePedigreeIds()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetGenerateEdgePedigreeIds_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkXMLTreeReader_GetGenerateVertexPedigreeIds_08(HandleRef pThis);

		public virtual bool GetGenerateVertexPedigreeIds()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetGenerateVertexPedigreeIds_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkXMLTreeReader_GetMaskArrays_09(HandleRef pThis);

		public virtual bool GetMaskArrays()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetMaskArrays_09(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkXMLTreeReader_GetReadCharData_10(HandleRef pThis);

		public virtual bool GetReadCharData()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetReadCharData_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkXMLTreeReader_GetReadTagName_11(HandleRef pThis);

		public virtual bool GetReadTagName()
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_GetReadTagName_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLTreeReader_GetVertexPedigreeIdArrayName_12(HandleRef pThis);

		public virtual string GetVertexPedigreeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetVertexPedigreeIdArrayName_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLTreeReader_GetXMLString_13(HandleRef pThis);

		public virtual string GetXMLString()
		{
			return Marshal.PtrToStringAnsi(vtkXMLTreeReader.vtkXMLTreeReader_GetXMLString_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkXMLTreeReader_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkXMLTreeReader_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLTreeReader.vtkXMLTreeReader_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_MaskArraysOff_16(HandleRef pThis);

		public virtual void MaskArraysOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_MaskArraysOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_MaskArraysOn_17(HandleRef pThis);

		public virtual void MaskArraysOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_MaskArraysOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLTreeReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLTreeReader NewInstance()
		{
			vtkXMLTreeReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLTreeReader.vtkXMLTreeReader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_ReadCharDataOff_20(HandleRef pThis);

		public virtual void ReadCharDataOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadCharDataOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_ReadCharDataOn_21(HandleRef pThis);

		public virtual void ReadCharDataOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadCharDataOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_ReadTagNameOff_22(HandleRef pThis);

		public virtual void ReadTagNameOff()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadTagNameOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_ReadTagNameOn_23(HandleRef pThis);

		public virtual void ReadTagNameOn()
		{
			vtkXMLTreeReader.vtkXMLTreeReader_ReadTagNameOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLTreeReader_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLTreeReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLTreeReader vtkXMLTreeReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLTreeReader.vtkXMLTreeReader_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLTreeReader = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLTreeReader.Register(null);
				}
			}
			return vtkXMLTreeReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetEdgePedigreeIdArrayName_25(HandleRef pThis, string _arg);

		public virtual void SetEdgePedigreeIdArrayName(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetEdgePedigreeIdArrayName_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetFileName_26(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetFileName_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetGenerateEdgePedigreeIds_27(HandleRef pThis, byte _arg);

		public virtual void SetGenerateEdgePedigreeIds(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetGenerateEdgePedigreeIds_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetGenerateVertexPedigreeIds_28(HandleRef pThis, byte _arg);

		public virtual void SetGenerateVertexPedigreeIds(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetGenerateVertexPedigreeIds_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetMaskArrays_29(HandleRef pThis, byte _arg);

		public virtual void SetMaskArrays(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetMaskArrays_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetReadCharData_30(HandleRef pThis, byte _arg);

		public virtual void SetReadCharData(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetReadCharData_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetReadTagName_31(HandleRef pThis, byte _arg);

		public virtual void SetReadTagName(bool _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetReadTagName_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetVertexPedigreeIdArrayName_32(HandleRef pThis, string _arg);

		public virtual void SetVertexPedigreeIdArrayName(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetVertexPedigreeIdArrayName_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkXMLTreeReader_SetXMLString_33(HandleRef pThis, string _arg);

		public virtual void SetXMLString(string _arg)
		{
			vtkXMLTreeReader.vtkXMLTreeReader_SetXMLString_33(base.GetCppThis(), _arg);
		}
	}
}
