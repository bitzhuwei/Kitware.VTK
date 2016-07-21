using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLShader : vtkObject
	{
		public enum LanguageCodes
		{
			LANGUAGE_CG = 2,
			LANGUAGE_GLSL,
			LANGUAGE_MIXED = 1,
			LANGUAGE_NONE = 0
		}

		public enum LocationCodes
		{
			LOCATION_FILE = 2,
			LOCATION_INLINE = 1,
			LOCATION_LIBRARY = 3,
			LOCATION_NONE = 0
		}

		public enum ScopeCodes
		{
			SCOPE_FRAGMENT = 3,
			SCOPE_MIXED = 1,
			SCOPE_NONE = 0,
			SCOPE_VERTEX = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLShader";

		public new static readonly string MRClassNameKey;

		static vtkXMLShader()
		{
			vtkXMLShader.MRClassNameKey = "class vtkXMLShader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLShader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLShader"));
		}

		public vtkXMLShader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLShader New()
		{
			vtkXMLShader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLShader.vtkXMLShader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLShader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLShader.vtkXMLShader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_GetCode_01(HandleRef pThis);

		public string GetCode()
		{
			return Marshal.PtrToStringAnsi(vtkXMLShader.vtkXMLShader_GetCode_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_GetEntry_02(HandleRef pThis);

		public string GetEntry()
		{
			return Marshal.PtrToStringAnsi(vtkXMLShader.vtkXMLShader_GetEntry_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLShader_GetLanguage_03(HandleRef pThis);

		public int GetLanguage()
		{
			return vtkXMLShader.vtkXMLShader_GetLanguage_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLShader_GetLocation_04(HandleRef pThis);

		public int GetLocation()
		{
			return vtkXMLShader.vtkXMLShader_GetLocation_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_GetName_05(HandleRef pThis);

		public string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLShader.vtkXMLShader_GetName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_GetRootElement_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXMLDataElement GetRootElement()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLShader.vtkXMLShader_GetRootElement_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLShader_GetScope_07(HandleRef pThis);

		public int GetScope()
		{
			return vtkXMLShader.vtkXMLShader_GetScope_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLShader_GetStyle_08(HandleRef pThis);

		public int GetStyle()
		{
			return vtkXMLShader.vtkXMLShader_GetStyle_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLShader_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLShader.vtkXMLShader_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLShader_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLShader.vtkXMLShader_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_LocateFile_11(string filename);

		public static string LocateFile(string filename)
		{
			return Marshal.PtrToStringAnsi(vtkXMLShader.vtkXMLShader_LocateFile_11(filename));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLShader NewInstance()
		{
			vtkXMLShader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLShader.vtkXMLShader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLShader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLShader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLShader vtkXMLShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLShader.vtkXMLShader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLShader = (vtkXMLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLShader.Register(null);
				}
			}
			return vtkXMLShader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLShader_SetRootElement_15(HandleRef pThis, HandleRef arg0);

		public void SetRootElement(vtkXMLDataElement arg0)
		{
			vtkXMLShader.vtkXMLShader_SetRootElement_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
